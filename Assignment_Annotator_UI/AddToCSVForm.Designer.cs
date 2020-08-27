namespace Assignment_Annotator_UI
{
    partial class AddToCSVForm
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
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnAppend = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSName = new System.Windows.Forms.TextBox();
            this.txtSIndex = new System.Windows.Forms.TextBox();
            this.txtCSVFileName = new System.Windows.Forms.TextBox();
            this.txtSaveFileName = new System.Windows.Forms.TextBox();
            this.dtpSubDate = new System.Windows.Forms.DateTimePicker();
            this.chbIsLateSub = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMarks = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(287, 132);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 5;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnAppend
            // 
            this.btnAppend.Location = new System.Drawing.Point(206, 201);
            this.btnAppend.Name = "btnAppend";
            this.btnAppend.Size = new System.Drawing.Size(75, 23);
            this.btnAppend.TabIndex = 8;
            this.btnAppend.Text = "Append";
            this.btnAppend.UseVisualStyleBackColor = true;
            this.btnAppend.Click += new System.EventHandler(this.btnAppend_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(287, 201);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Student\'s Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Student\'s Index No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Submission Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Is Late Submission";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "CSV file";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "File Name";
            // 
            // txtSName
            // 
            this.txtSName.Location = new System.Drawing.Point(115, 5);
            this.txtSName.Name = "txtSName";
            this.txtSName.Size = new System.Drawing.Size(241, 20);
            this.txtSName.TabIndex = 0;
            // 
            // txtSIndex
            // 
            this.txtSIndex.Location = new System.Drawing.Point(115, 37);
            this.txtSIndex.Name = "txtSIndex";
            this.txtSIndex.Size = new System.Drawing.Size(163, 20);
            this.txtSIndex.TabIndex = 1;
            // 
            // txtCSVFileName
            // 
            this.txtCSVFileName.Location = new System.Drawing.Point(115, 133);
            this.txtCSVFileName.Name = "txtCSVFileName";
            this.txtCSVFileName.Size = new System.Drawing.Size(163, 20);
            this.txtCSVFileName.TabIndex = 6;
            // 
            // txtSaveFileName
            // 
            this.txtSaveFileName.Location = new System.Drawing.Point(115, 165);
            this.txtSaveFileName.Name = "txtSaveFileName";
            this.txtSaveFileName.Size = new System.Drawing.Size(163, 20);
            this.txtSaveFileName.TabIndex = 7;
            // 
            // dtpSubDate
            // 
            this.dtpSubDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSubDate.Location = new System.Drawing.Point(115, 69);
            this.dtpSubDate.Name = "dtpSubDate";
            this.dtpSubDate.Size = new System.Drawing.Size(100, 20);
            this.dtpSubDate.TabIndex = 2;
            // 
            // chbIsLateSub
            // 
            this.chbIsLateSub.AutoSize = true;
            this.chbIsLateSub.Location = new System.Drawing.Point(115, 103);
            this.chbIsLateSub.Name = "chbIsLateSub";
            this.chbIsLateSub.Size = new System.Drawing.Size(44, 17);
            this.chbIsLateSub.TabIndex = 3;
            this.chbIsLateSub.Text = "Yes";
            this.chbIsLateSub.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(183, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Marks";
            // 
            // txtMarks
            // 
            this.txtMarks.Location = new System.Drawing.Point(225, 101);
            this.txtMarks.Name = "txtMarks";
            this.txtMarks.Size = new System.Drawing.Size(53, 20);
            this.txtMarks.TabIndex = 4;
            // 
            // AddToCSVForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 230);
            this.ControlBox = false;
            this.Controls.Add(this.txtMarks);
            this.Controls.Add(this.chbIsLateSub);
            this.Controls.Add(this.dtpSubDate);
            this.Controls.Add(this.txtSaveFileName);
            this.Controls.Add(this.txtCSVFileName);
            this.Controls.Add(this.txtSIndex);
            this.Controls.Add(this.txtSName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAppend);
            this.Controls.Add(this.btnBrowse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddToCSVForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddToCSVForm";
            this.Load += new System.EventHandler(this.AddToCSVForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnAppend;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSName;
        private System.Windows.Forms.TextBox txtSIndex;
        private System.Windows.Forms.TextBox txtCSVFileName;
        private System.Windows.Forms.TextBox txtSaveFileName;
        private System.Windows.Forms.DateTimePicker dtpSubDate;
        private System.Windows.Forms.CheckBox chbIsLateSub;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMarks;
    }
}