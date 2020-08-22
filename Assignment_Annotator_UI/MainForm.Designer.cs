namespace Assignment_Annotator_UI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCheckForUpdates = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mainToolsMenu = new System.Windows.Forms.ToolStrip();
            this.btnOpen = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnPrev = new System.Windows.Forms.ToolStripButton();
            this.txtPage = new System.Windows.Forms.ToolStripTextBox();
            this.btnNext = new System.Windows.Forms.ToolStripButton();
            this.txtScore = new System.Windows.Forms.ToolStripTextBox();
            this.txtFullScore = new System.Windows.Forms.ToolStripTextBox();
            this.btnCorrect = new System.Windows.Forms.ToolStripButton();
            this.btnWrong = new System.Windows.Forms.ToolStripButton();
            this.btnSelect = new System.Windows.Forms.ToolStripButton();
            this.btnText = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.pnlImage = new System.Windows.Forms.Panel();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.vsbImage = new System.Windows.Forms.VScrollBar();
            this.cmsImage = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previousPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectCorrectAnnotationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectIncorrectAnnotationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectTextAnnotationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAnnotationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSelectedAnnotationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.openDocumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDocumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repositionFinalScoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu.SuspendLayout();
            this.mainToolsMenu.SuspendLayout();
            this.pnlImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.cmsImage.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(886, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCheckForUpdates,
            this.tsmiAbout});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // tsmiCheckForUpdates
            // 
            this.tsmiCheckForUpdates.Name = "tsmiCheckForUpdates";
            this.tsmiCheckForUpdates.Size = new System.Drawing.Size(230, 22);
            this.tsmiCheckForUpdates.Text = "Check for Updates";
            this.tsmiCheckForUpdates.Click += new System.EventHandler(this.tsmiCheckForUpdates_Click);
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(230, 22);
            this.tsmiAbout.Text = "About Assignment Annotator";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // mainToolsMenu
            // 
            this.mainToolsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOpen,
            this.btnSave,
            this.toolStripSeparator1,
            this.btnPrev,
            this.txtPage,
            this.btnNext,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.txtScore,
            this.toolStripLabel2,
            this.txtFullScore,
            this.toolStripSeparator3,
            this.btnCorrect,
            this.btnWrong,
            this.btnText,
            this.toolStripSeparator4,
            this.btnSelect,
            this.btnDelete});
            this.mainToolsMenu.Location = new System.Drawing.Point(0, 24);
            this.mainToolsMenu.Name = "mainToolsMenu";
            this.mainToolsMenu.Size = new System.Drawing.Size(886, 25);
            this.mainToolsMenu.TabIndex = 1;
            this.mainToolsMenu.Text = "toolStrip1";
            // 
            // btnOpen
            // 
            this.btnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOpen.Image = global::Assignment_Annotator_UI.Properties.Resources.Open;
            this.btnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(23, 22);
            this.btnOpen.Text = "toolStripButton1";
            this.btnOpen.ToolTipText = "Open document";
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSave.Image = global::Assignment_Annotator_UI.Properties.Resources.Save;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(23, 22);
            this.btnSave.Text = "toolStripButton1";
            this.btnSave.ToolTipText = "Save document";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPrev.Image = global::Assignment_Annotator_UI.Properties.Resources.Prev;
            this.btnPrev.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(23, 22);
            this.btnPrev.Text = "toolStripButton1";
            this.btnPrev.ToolTipText = "Goto previous page";
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // txtPage
            // 
            this.txtPage.Enabled = false;
            this.txtPage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPage.Name = "txtPage";
            this.txtPage.Size = new System.Drawing.Size(50, 25);
            // 
            // btnNext
            // 
            this.btnNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNext.Image = global::Assignment_Annotator_UI.Properties.Resources.Next;
            this.btnNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(23, 22);
            this.btnNext.Text = "toolStripButton1";
            this.btnNext.ToolTipText = "Goto next page";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // txtScore
            // 
            this.txtScore.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(25, 25);
            this.txtScore.TextChanged += new System.EventHandler(this.txtScore_TextChanged);
            // 
            // txtFullScore
            // 
            this.txtFullScore.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFullScore.Name = "txtFullScore";
            this.txtFullScore.Size = new System.Drawing.Size(40, 25);
            this.txtFullScore.TextChanged += new System.EventHandler(this.txtFullScore_TextChanged);
            // 
            // btnCorrect
            // 
            this.btnCorrect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCorrect.Image = global::Assignment_Annotator_UI.Properties.Resources.Ricon;
            this.btnCorrect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCorrect.Name = "btnCorrect";
            this.btnCorrect.Size = new System.Drawing.Size(23, 22);
            this.btnCorrect.Text = "toolStripButton1";
            this.btnCorrect.ToolTipText = "Select correct annotaion";
            this.btnCorrect.Click += new System.EventHandler(this.btnCorrect_Click);
            // 
            // btnWrong
            // 
            this.btnWrong.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnWrong.Image = global::Assignment_Annotator_UI.Properties.Resources.Wicon;
            this.btnWrong.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnWrong.Name = "btnWrong";
            this.btnWrong.Size = new System.Drawing.Size(23, 22);
            this.btnWrong.Text = "toolStripButton2";
            this.btnWrong.ToolTipText = "Select incorrect annotation";
            this.btnWrong.Click += new System.EventHandler(this.btnWrong_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSelect.Image = global::Assignment_Annotator_UI.Properties.Resources.Select;
            this.btnSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(23, 22);
            this.btnSelect.Text = "toolStripButton3";
            this.btnSelect.ToolTipText = "Select annotaions";
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnText
            // 
            this.btnText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnText.Image = global::Assignment_Annotator_UI.Properties.Resources.Text;
            this.btnText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnText.Name = "btnText";
            this.btnText.Size = new System.Drawing.Size(23, 22);
            this.btnText.Text = "toolStripButton4";
            this.btnText.ToolTipText = "Select comment annotation";
            this.btnText.Click += new System.EventHandler(this.btnText_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDelete.Image = global::Assignment_Annotator_UI.Properties.Resources.Delete;
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(23, 22);
            this.btnDelete.Text = "toolStripButton1";
            this.btnDelete.ToolTipText = "Delete selected annotations";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pnlImage
            // 
            this.pnlImage.Controls.Add(this.pbImage);
            this.pnlImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlImage.Location = new System.Drawing.Point(0, 49);
            this.pnlImage.Name = "pnlImage";
            this.pnlImage.Size = new System.Drawing.Size(869, 401);
            this.pnlImage.TabIndex = 2;
            // 
            // pbImage
            // 
            this.pbImage.ContextMenuStrip = this.cmsImage;
            this.pbImage.Location = new System.Drawing.Point(0, 0);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(673, 338);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            this.pbImage.Paint += new System.Windows.Forms.PaintEventHandler(this.pbImage_Paint);
            this.pbImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbImage_MouseDown);
            this.pbImage.MouseLeave += new System.EventHandler(this.pbImage_MouseLeave);
            this.pbImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbImage_MouseMove);
            this.pbImage.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.pbImage_MouseWheel);
            // 
            // vsbImage
            // 
            this.vsbImage.Dock = System.Windows.Forms.DockStyle.Right;
            this.vsbImage.Location = new System.Drawing.Point(869, 49);
            this.vsbImage.Name = "vsbImage";
            this.vsbImage.Size = new System.Drawing.Size(17, 401);
            this.vsbImage.TabIndex = 3;
            this.vsbImage.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vsbImage_Scroll);
            // 
            // cmsImage
            // 
            this.cmsImage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nextPageToolStripMenuItem,
            this.previousPageToolStripMenuItem,
            this.selectCorrectAnnotationToolStripMenuItem,
            this.selectIncorrectAnnotationToolStripMenuItem,
            this.selectTextAnnotationToolStripMenuItem,
            this.selectAnnotationsToolStripMenuItem,
            this.deleteSelectedAnnotationsToolStripMenuItem,
            this.repositionFinalScoreToolStripMenuItem});
            this.cmsImage.Name = "cmsImage";
            this.cmsImage.Size = new System.Drawing.Size(220, 180);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(39, 22);
            this.toolStripLabel1.Text = "Score:";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(12, 22);
            this.toolStripLabel2.Text = "/";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openDocumentToolStripMenuItem,
            this.saveDocumentToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // nextPageToolStripMenuItem
            // 
            this.nextPageToolStripMenuItem.Name = "nextPageToolStripMenuItem";
            this.nextPageToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.nextPageToolStripMenuItem.Text = "Next Page";
            this.nextPageToolStripMenuItem.Click += new System.EventHandler(this.nextPageToolStripMenuItem_Click);
            // 
            // previousPageToolStripMenuItem
            // 
            this.previousPageToolStripMenuItem.Name = "previousPageToolStripMenuItem";
            this.previousPageToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.previousPageToolStripMenuItem.Text = "Previous Page";
            this.previousPageToolStripMenuItem.Click += new System.EventHandler(this.previousPageToolStripMenuItem_Click);
            // 
            // selectCorrectAnnotationToolStripMenuItem
            // 
            this.selectCorrectAnnotationToolStripMenuItem.Name = "selectCorrectAnnotationToolStripMenuItem";
            this.selectCorrectAnnotationToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.selectCorrectAnnotationToolStripMenuItem.Text = "Select correct annotation";
            this.selectCorrectAnnotationToolStripMenuItem.Click += new System.EventHandler(this.selectCorrectAnnotationToolStripMenuItem_Click);
            // 
            // selectIncorrectAnnotationToolStripMenuItem
            // 
            this.selectIncorrectAnnotationToolStripMenuItem.Name = "selectIncorrectAnnotationToolStripMenuItem";
            this.selectIncorrectAnnotationToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.selectIncorrectAnnotationToolStripMenuItem.Text = "Select incorrect annotation";
            this.selectIncorrectAnnotationToolStripMenuItem.Click += new System.EventHandler(this.selectIncorrectAnnotationToolStripMenuItem_Click);
            // 
            // selectTextAnnotationToolStripMenuItem
            // 
            this.selectTextAnnotationToolStripMenuItem.Name = "selectTextAnnotationToolStripMenuItem";
            this.selectTextAnnotationToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.selectTextAnnotationToolStripMenuItem.Text = "Select text annotation";
            this.selectTextAnnotationToolStripMenuItem.Click += new System.EventHandler(this.selectTextAnnotationToolStripMenuItem_Click);
            // 
            // selectAnnotationsToolStripMenuItem
            // 
            this.selectAnnotationsToolStripMenuItem.Name = "selectAnnotationsToolStripMenuItem";
            this.selectAnnotationsToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.selectAnnotationsToolStripMenuItem.Text = "Select annotations";
            this.selectAnnotationsToolStripMenuItem.Click += new System.EventHandler(this.selectAnnotationsToolStripMenuItem_Click);
            // 
            // deleteSelectedAnnotationsToolStripMenuItem
            // 
            this.deleteSelectedAnnotationsToolStripMenuItem.Name = "deleteSelectedAnnotationsToolStripMenuItem";
            this.deleteSelectedAnnotationsToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.deleteSelectedAnnotationsToolStripMenuItem.Text = "Delete selected annotations";
            this.deleteSelectedAnnotationsToolStripMenuItem.Click += new System.EventHandler(this.deleteSelectedAnnotationsToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // openDocumentToolStripMenuItem
            // 
            this.openDocumentToolStripMenuItem.Name = "openDocumentToolStripMenuItem";
            this.openDocumentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openDocumentToolStripMenuItem.Text = "Open document";
            this.openDocumentToolStripMenuItem.Click += new System.EventHandler(this.openDocumentToolStripMenuItem_Click);
            // 
            // saveDocumentToolStripMenuItem
            // 
            this.saveDocumentToolStripMenuItem.Name = "saveDocumentToolStripMenuItem";
            this.saveDocumentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveDocumentToolStripMenuItem.Text = "Save document";
            this.saveDocumentToolStripMenuItem.Click += new System.EventHandler(this.saveDocumentToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // repositionFinalScoreToolStripMenuItem
            // 
            this.repositionFinalScoreToolStripMenuItem.Name = "repositionFinalScoreToolStripMenuItem";
            this.repositionFinalScoreToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.repositionFinalScoreToolStripMenuItem.Text = "Reposition final score";
            this.repositionFinalScoreToolStripMenuItem.Click += new System.EventHandler(this.repositionFinalScoreToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 450);
            this.Controls.Add(this.pnlImage);
            this.Controls.Add(this.vsbImage);
            this.Controls.Add(this.mainToolsMenu);
            this.Controls.Add(this.mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Assignment Annotator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.mainToolsMenu.ResumeLayout(false);
            this.mainToolsMenu.PerformLayout();
            this.pnlImage.ResumeLayout(false);
            this.pnlImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.cmsImage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStrip mainToolsMenu;
        private System.Windows.Forms.Panel pnlImage;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.VScrollBar vsbImage;
        private System.Windows.Forms.ContextMenuStrip cmsImage;
        private System.Windows.Forms.ToolStripTextBox txtPage;
        private System.Windows.Forms.ToolStripTextBox txtScore;
        private System.Windows.Forms.ToolStripTextBox txtFullScore;
        private System.Windows.Forms.ToolStripButton btnOpen;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnNext;
        private System.Windows.Forms.ToolStripButton btnPrev;
        private System.Windows.Forms.ToolStripButton btnCorrect;
        private System.Windows.Forms.ToolStripButton btnWrong;
        private System.Windows.Forms.ToolStripButton btnSelect;
        private System.Windows.Forms.ToolStripButton btnText;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiCheckForUpdates;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem nextPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previousPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectCorrectAnnotationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectIncorrectAnnotationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectTextAnnotationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAnnotationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSelectedAnnotationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openDocumentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveDocumentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repositionFinalScoreToolStripMenuItem;
    }
}

