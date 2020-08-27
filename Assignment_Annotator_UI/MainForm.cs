using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using SharpUpdate;
using System.Reflection;

namespace Assignment_Annotator_UI
{
    public partial class MainForm : Form
    {
        AboutForm aboutForm;
        SharpUpdater updater;
        bool ctScore = false;
        int pageIndex = 0;
        int xf = 0; //fraction from 1000
        int yf = 0;
        char annotationType = 'C';
        string score = "1";
        List<Pages> pages;
        List<Annotation> ticks = new List<Annotation>();
        //bool placingFinal = false;
        Point hover = new Point(0, 0);
        Font drawFont = new Font("Arial", 14);
        Font drawFontL = new Font("Arial", 24);
        Font textFont = new Font("Arial", 14);
        SolidBrush drawBrush = new SolidBrush(System.Drawing.Color.Red);
        SolidBrush drawBrush_selected = new SolidBrush(System.Drawing.Color.Blue);
        public static bool isSaved = true;
        string WelcomeFilePath = "Stamps\\Original.pdf";

        public MainForm()
        {
            InitializeComponent();

            DATA.pageCount = 0;
            updater = new SharpUpdater(Assembly.GetExecutingAssembly(), this, new Uri("https://raw.githubusercontent.com/DinushaMS/Assignment-Annotator-Final/master/Assignment_Annotator_UI/bin/Publish/update.xml"));
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            //MessageBox.Show($"{e.KeyValue},{e.KeyCode},{e.KeyData}");
            int n = e.KeyValue - 48;
            if (!ctScore)
            {
                score = "";
                ctScore = true;
            }
            if (n > -1 && n < 10)
                score += n.ToString();
            if (score.Length > 2)
                score = "";
            if (e.KeyCode == Keys.Delete)
            {
                DeleteTicks();
            }
            else if (e.KeyCode == Keys.S)
            {
                annotationType = 'S';
            }
            else if (e.KeyCode == Keys.T)
            {
                annotationType = 'T';
            }
            else if (e.KeyCode == Keys.C)
            {
                annotationType = 'C';
            }
            else if (e.KeyCode == Keys.W)
            {
                annotationType = 'I';
            }
            pbImage.Refresh();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenPDF();
        }

        private void OpenPDF()
        {
            if (!isSaved)
            {
                DialogResult res = MessageBox.Show("Document not saved. Ignore and continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    OFD();
                }
            }
            else
            {
                OFD();
            }

        }

        private void OpenFile(string filePath)
        {
            //if (DATA.OriginalImages != null)
            //    pbImage.Image = DATA.OriginalImages[1];

            DATA.panelWidth = pnlImage.Width;
            DATA.sourcePDFpath = filePath;
            DATA.sourceImageDirpath = Path.Combine(Path.GetTempPath(), "PA_Images");
            this.Text = $"Assignment Annotator - {DATA.fileName}*";
            Console.WriteLine(filePath);
            Console.WriteLine(Path.GetDirectoryName(filePath));
            PDF2IMG p2i = new PDF2IMG();
            try
            {
                if (DATA.OriginalImages != null)
                    pbImage.Image = DATA.OriginalImages[0];
                DATA.OriginalImages = new List<Bitmap>();
                p2i.ConvertPDF2Image(DATA.sourcePDFpath, DATA.sourceImageDirpath, "page", ImageFormat.Jpeg);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ticks = new List<Annotation>();
            pages = new List<Pages>();
            DATA.finalScore = 0;
            for (int i = 0; i < DATA.pageCount; i++)
            {
                Pages p = new Pages();
                pages.Add(p);
            }
            ViewPage();
        }

        private void OFD()
        {
            isSaved = false;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "PDF Files | *.pdf";
            ofd.DefaultExt = "pdf";
            DialogResult response = ofd.ShowDialog();
            Console.WriteLine(ofd.FileName);
            DATA.fileName = Path.GetFileName(ofd.FileName);
            if (response == DialogResult.OK)
            {
                OpenFile(ofd.FileName);
            }
        }
        private void pbImage_MouseWheel(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            int numberOfTextLinesToMove = e.Delta * SystemInformation.MouseWheelScrollLines / 30;
            //Console.WriteLine($"Hit{numberOfTextLinesToMove}");
            if (vsbImage.Value - numberOfTextLinesToMove >= 0 && vsbImage.Value - numberOfTextLinesToMove <= vsbImage.Maximum)
            {
                vsbImage.Value -= numberOfTextLinesToMove;
                pbImage.Location = new Point(pbImage.Location.X, -1 * vsbImage.Value);
                Draw();
            }
        }

        private void ViewPage()
        {
            vsbImage.Maximum = DATA.OriginalImages[pageIndex].Height - pnlImage.Height;
            txtPage.Text = $"{pageIndex + 1} of {DATA.pageCount}";
            pbImage.Location = new Point(0, 0);
            vsbImage.Value = 0;
            ticks.Clear();
            if (pages[pageIndex].tick != null)
                ticks.AddRange(pages[pageIndex].tick);
            Draw();
        }

        private void vsbImage_Scroll(object sender, ScrollEventArgs e)
        {
            pbImage.Location = new Point(pbImage.Location.X, -1 * vsbImage.Value);
            Draw();
        }

        private void Draw()
        {     
            if (true)//paintEnabled && DATA.OriginalImages != null)
            {
                pbImage.Image = GetCopyImage($"{DATA.sourceImageDirpath}\\page{pageIndex + 1}.Jpeg");
            }
        }

        private Image GetCopyImage(string path)
        {
            int x = 0, y = 0;
            using (Image imageFile = Image.FromFile(path))
            {
                Graphics newGraphics = Graphics.FromImage(imageFile);
                foreach (var item in ticks)
                {
                    x = (item.x * DATA.OriginalImages[pageIndex].Width) / 1000;
                    y = (item.y * DATA.OriginalImages[pageIndex].Height) / 1000 - PDF.iHeight / 2;
                    if (!item.isSelceted)
                    {
                        if (item.Type == 'C')
                            newGraphics.DrawImage(Properties.Resources.correct, x, y, PDF.iWidth, PDF.iHeight);
                        else if (item.Type == 'I')
                            newGraphics.DrawImage(Properties.Resources.wrong, x, y, PDF.iWidth, PDF.iHeight);
                        else
                            newGraphics.DrawString(item.text, textFont, drawBrush, x, y + PDF.iHeight / 2);
                        if ((item.Type == 'C' || item.Type == 'I') && item.text != "")
                            newGraphics.DrawString($"({item.text})", drawFont, drawBrush, x + PDF.iWidth, y + PDF.iHeight / 2);
                    }
                    else//if selected
                    {
                        if (item.Type == 'C')
                            newGraphics.DrawImage(Properties.Resources.correct_selected, x, y, PDF.iWidth, PDF.iHeight);
                        else if (item.Type == 'I')
                            newGraphics.DrawImage(Properties.Resources.wrong_selected, x, y, PDF.iWidth, PDF.iHeight);
                        else
                            newGraphics.DrawString(item.text, textFont, drawBrush_selected, x, y + PDF.iHeight / 2);
                        if ((item.Type == 'C' || item.Type == 'I') && item.text != "")
                            newGraphics.DrawString($"({item.text})", drawFont, drawBrush_selected, x + PDF.iWidth, y + PDF.iHeight / 2);
                    }
                }

                if (pageIndex == 0 && DATA.sourcePDFpath != WelcomeFilePath)
                {
                    x = (PDF.fScoreOrigin.X * DATA.OriginalImages[pageIndex].Width) / 1000;
                    y = (PDF.fScoreOrigin.Y * DATA.OriginalImages[pageIndex].Height) / 1000;
                    newGraphics.DrawString($"{DATA.finalScore}", drawFont, drawBrush, x, y);
                    newGraphics.DrawString($"------", drawFont, drawBrush, x, y + 16);
                    newGraphics.DrawString($"{DATA.outOf}", drawFont, drawBrush, x, y + 40);
                }
                //pictureBox1.Image = (Image)imageFile.Clone();                
                Bitmap bm = new Bitmap(imageFile);
                newGraphics.Dispose();
                return bm;
            }
        }

        private void pbImage_Paint(object sender, PaintEventArgs e)
        {
            if (DATA.sourcePDFpath != WelcomeFilePath)//paintEnabled && DATA.OriginalImages != null)
            {
                if (annotationType == 'C')
                    e.Graphics.DrawImage(Properties.Resources.correct, hover.X, hover.Y - PDF.iHeight / 2, PDF.iWidth, PDF.iHeight);
                else if (annotationType == 'I')
                    e.Graphics.DrawImage(Properties.Resources.wrong, hover.X, hover.Y - PDF.iHeight / 2, PDF.iWidth, PDF.iHeight);
                else if (annotationType == 'M')
                {
                    e.Graphics.DrawString($"{DATA.finalScore}", drawFontL, drawBrush, hover.X, hover.Y);
                    e.Graphics.DrawString($"------", drawFontL, drawBrush, hover.X, hover.Y + 16);
                    e.Graphics.DrawString($"{DATA.outOf}", drawFontL, drawBrush, hover.X, hover.Y + 40);
                }

                if ((annotationType == 'C' || annotationType == 'I') && score != "")
                    e.Graphics.DrawString($"({score})", drawFontL, drawBrush, hover.X + PDF.iWidth, hover.Y);
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (pageIndex - 1 >= 0)
            {
                pageIndex -= 1;
                ViewPage();
            }

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (pageIndex + 1 <= DATA.pageCount - 1)
            {
                pageIndex += 1;
                ViewPage();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveDocument();
        }

        private void SaveDocument()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF Files | *.pdf";
            sfd.DefaultExt = "pdf";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                DATA.fileName = Path.GetFileName(sfd.FileName);
                PDF.Export(sfd.FileName, pages.ToArray());
                //this.Text = $"PDF Assignment Grader - {Path.GetFileName(DATA.fileName)}";
            }
        }

        private void AddTick()
        {
            if(DATA.sourcePDFpath != WelcomeFilePath)
            {
                Annotation tick = new Annotation();
                tick.Type = annotationType;
                if (annotationType == 'T')
                    tick.text = DATA.Comment;
                else
                {
                    tick.text = score;
                    ctScore = false;
                }

                tick.x = xf;
                tick.y = yf;
                tick.isSelceted = false;
                ticks.Add(tick);
                if (pages != null)
                {
                    pages[pageIndex].tick = ticks.ToArray();
                }
                DATA.finalScore = 0;
                for (int i = 1; i <= DATA.pageCount; i++)
                {
                    if (pages[i - 1].tick != null)
                    {
                        foreach (var item in pages[i - 1].tick)
                        {
                            if (item.text != "" && item.Type != 'T')
                            {
                                double val = 0;
                                if (Double.TryParse(item.text, out val))
                                {
                                    DATA.finalScore += val;
                                    txtScore.Text = DATA.finalScore.ToString();
                                }
                                else
                                {
                                    MessageBox.Show("Marks must be a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    ticks.RemoveAt(ticks.Count - 1);
                                }

                            }
                        }
                        if (DATA.finalScore > DATA.outOf)
                            MessageBox.Show("Total score is over the maximum value!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            
        }

        private void pbImage_MouseMove(object sender, MouseEventArgs e)
        {
            hover.X = e.X;
            hover.Y = e.Y;
            if (annotationType == 'S')
                pbImage.Cursor = Cursors.Hand;
            else if (annotationType == 'T')
                pbImage.Cursor = Cursors.IBeam;
            else if (annotationType == 'C' || annotationType == 'I')
                pbImage.Cursor = Cursors.Cross;
            else
                pbImage.Cursor = Cursors.Default;
            pbImage.Refresh();
        }

        private void btnCorrect_Click(object sender, EventArgs e)
        {
            annotationType = 'C';
        }

        private void btnWrong_Click(object sender, EventArgs e)
        {
            annotationType = 'I';
        }

        private void btnText_Click(object sender, EventArgs e)
        {
            annotationType = 'T';
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteTicks();
        }

        private void DeleteTicks()
        {
            ticks = ticks.Where(c => !c.isSelceted).ToList<Annotation>();
            if (pages != null)
            {
                pages[pageIndex].tick = ticks.ToArray();
            }
            CalculateFinalScore();
            Draw();
        }

        private void CalculateFinalScore()
        {
            DATA.finalScore = 0;
            for (int i = 1; i <= DATA.pageCount; i++)
            {
                if (pages[i - 1].tick != null)
                {
                    foreach (var item in pages[i - 1].tick)
                    {
                        if (item.text != "" && item.Type != 'T')
                        {
                            DATA.finalScore += Convert.ToDouble(item.text);
                            txtScore.Text = DATA.finalScore.ToString();
                        }
                    }
                }
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            annotationType = 'S';

        }

        private void pbImage_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && DATA.OriginalImages != null)
            {
                xf = (e.X * 1000) / DATA.OriginalImages[pageIndex].Width;
                yf = (e.Y * 1000) / DATA.OriginalImages[pageIndex].Height;
                if (annotationType == 'S')
                {
                    for (int i = 0; i < ticks.Count; i++)
                    {
                        int x = (ticks[i].x * DATA.OriginalImages[pageIndex].Width) / 1000;
                        int y = (ticks[i].y * DATA.OriginalImages[pageIndex].Height) / 1000;
                        if (e.X > x && e.X < x + PDF.iHeight / 2)
                            if (e.Y > y && e.Y < y + PDF.iHeight / 2)
                            {
                                if (!ticks[i].isSelceted)
                                {
                                    ticks[i].isSelceted = true;
                                }
                                else
                                {
                                    ticks[i].isSelceted = false;
                                }
                                break;
                            }
                    }
                }
                else if (annotationType == 'T')
                {
                    //Create an instance of your dialog form
                    CommentForm testDialog = new CommentForm();
                    testDialog.Location = new Point(e.X, e.Y + testDialog.Height / 2);
                    testDialog.StartPosition = FormStartPosition.Manual;

                    // Show testDialog as a modal dialog and determine if DialogResult = OK.
                    if (testDialog.ShowDialog(this) == DialogResult.OK)
                    {
                        AddTick();
                    }
                }
                else if (annotationType == 'M')
                {
                    PDF.fScoreOrigin = new Point(xf, yf);
                }
                else
                {
                    AddTick();
                }
                Draw();
            }
            else if (e.Button == MouseButtons.Right)
            {
                //mainMenu.Show(this, new Point(e.X, e.Y));
            }
        }

        private void pbImage_MouseLeave(object sender, EventArgs e)
        {
            pbImage.Cursor = Cursors.Default;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenPDF();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                DATA.fileName = Path.GetFileName(sfd.FileName);
                PDF.Export(sfd.FileName, pages.ToArray());
                //this.Text = $"PDF Assignment Grader - {Path.GetFileName(DATA.fileName)}";
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtScore_TextChanged(object sender, EventArgs e)
        {
            Double value;
            if (Double.TryParse(txtScore.Text, out value))
                DATA.finalScore = value;
        }

        private void txtFullScore_TextChanged(object sender, EventArgs e)
        {
            Int16 value;
            if (Int16.TryParse(txtFullScore.Text, out value))
                DATA.outOf = value;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isSaved)
            {
                DialogResult res = MessageBox.Show("Document not saved. Ignore and quit?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.No)
                    e.Cancel = true;
            }
        }

        private void tsmiCheckForUpdates_Click(object sender, EventArgs e)
        {
            updater.DoUpdate();
        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            if (aboutForm == null)
            {
                aboutForm = new AboutForm();
                aboutForm.Show();
            }
            else
                aboutForm.Activate();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openDocumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenPDF();
        }

        private void nextPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pageIndex + 1 <= DATA.pageCount - 1)
            {
                pageIndex += 1;
                ViewPage();
            }
        }

        private void previousPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pageIndex - 1 >= 0 )
            {
                pageIndex -= 1;
                ViewPage();
            }
        }

        private void selectCorrectAnnotationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            annotationType = 'C';
        }

        private void selectIncorrectAnnotationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            annotationType = 'I';
        }

        private void selectTextAnnotationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            annotationType = 'T';
        }

        private void selectAnnotationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            annotationType = 'S';
        }

        private void deleteSelectedAnnotationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteTicks();
        }

        private void repositionFinalScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            annotationType = 'M';
        }

        private void saveDocumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveDocument();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (File.Exists(WelcomeFilePath))
            {
                //OpenFile(WelcomeFilePath);
            }
        }
    }
}
