using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_Annotator_UI
{
    public partial class AddToCSVForm : Form
    {
        string csvfilePath = "";
        public AddToCSVForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAppend_Click(object sender, EventArgs e)
        {
            DATA.fileName = Path.GetFileName(csvfilePath);
            try
            {
                PDF.Export(csvfilePath, MainForm.pages.ToArray());
                WriteCSV();                
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                MessageBox.Show("Data was appended and file was saved!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            

            this.Close();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {                
                txtCSVFileName.Text = Path.GetFileNameWithoutExtension(ofd.FileName);
                csvfilePath = ofd.FileName;
            }
        }

        private void WriteCSV()
        {
            //before your loop
            var csv = new StringBuilder();

            var name = txtSName.Text;
            var index = txtSIndex.Text;
            var marks = txtMarks.Text;
            //Suggestion made by KyleMit
            var newLine = $"{name},{index},{marks}";
            csv.AppendLine(newLine);

            //after your loop
            File.AppendAllText(csvfilePath, csv.ToString());
        }

        private void AddToCSVForm_Load(object sender, EventArgs e)
        {
            txtMarks.Text = DATA.finalScore.ToString();
        }
    }
}
