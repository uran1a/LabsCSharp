namespace lab8_winform
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonFindSum = new System.Windows.Forms.Button();
            this.textBoxResultTask1 = new System.Windows.Forms.TextBox();
            this.buttonCreateFileTask1 = new System.Windows.Forms.Button();
            this.textBoxTitleFile = new System.Windows.Forms.TextBox();
            this.buttonCreateFolderTask1 = new System.Windows.Forms.Button();
            this.textBoxTitleFolder = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(799, 448);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonFindSum);
            this.tabPage1.Controls.Add(this.textBoxResultTask1);
            this.tabPage1.Controls.Add(this.buttonCreateFileTask1);
            this.tabPage1.Controls.Add(this.textBoxTitleFile);
            this.tabPage1.Controls.Add(this.buttonCreateFolderTask1);
            this.tabPage1.Controls.Add(this.textBoxTitleFolder);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(791, 420);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Задание 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonFindSum
            // 
            this.buttonFindSum.Location = new System.Drawing.Point(152, 99);
            this.buttonFindSum.Name = "buttonFindSum";
            this.buttonFindSum.Size = new System.Drawing.Size(149, 36);
            this.buttonFindSum.TabIndex = 7;
            this.buttonFindSum.Text = "Найти сумму файла";
            this.buttonFindSum.UseVisualStyleBackColor = true;
            this.buttonFindSum.Click += new System.EventHandler(this.buttonFindSum_Click);
            // 
            // textBoxResultTask1
            // 
            this.textBoxResultTask1.Location = new System.Drawing.Point(9, 102);
            this.textBoxResultTask1.Multiline = true;
            this.textBoxResultTask1.Name = "textBoxResultTask1";
            this.textBoxResultTask1.ReadOnly = true;
            this.textBoxResultTask1.Size = new System.Drawing.Size(137, 33);
            this.textBoxResultTask1.TabIndex = 6;
            // 
            // buttonCreateFileTask1
            // 
            this.buttonCreateFileTask1.Location = new System.Drawing.Point(152, 57);
            this.buttonCreateFileTask1.Name = "buttonCreateFileTask1";
            this.buttonCreateFileTask1.Size = new System.Drawing.Size(119, 36);
            this.buttonCreateFileTask1.TabIndex = 5;
            this.buttonCreateFileTask1.Text = "Создать файл";
            this.buttonCreateFileTask1.UseVisualStyleBackColor = true;
            this.buttonCreateFileTask1.Click += new System.EventHandler(this.buttonCreateFileTask1_Click);
            // 
            // textBoxTitleFile
            // 
            this.textBoxTitleFile.Location = new System.Drawing.Point(8, 57);
            this.textBoxTitleFile.Multiline = true;
            this.textBoxTitleFile.Name = "textBoxTitleFile";
            this.textBoxTitleFile.Size = new System.Drawing.Size(138, 36);
            this.textBoxTitleFile.TabIndex = 4;
            // 
            // buttonCreateFolderTask1
            // 
            this.buttonCreateFolderTask1.Location = new System.Drawing.Point(152, 15);
            this.buttonCreateFolderTask1.Name = "buttonCreateFolderTask1";
            this.buttonCreateFolderTask1.Size = new System.Drawing.Size(119, 36);
            this.buttonCreateFolderTask1.TabIndex = 3;
            this.buttonCreateFolderTask1.Text = "Создать папку";
            this.buttonCreateFolderTask1.UseVisualStyleBackColor = true;
            this.buttonCreateFolderTask1.Click += new System.EventHandler(this.buttonCreateFolderTask1_Click);
            // 
            // textBoxTitleFolder
            // 
            this.textBoxTitleFolder.Location = new System.Drawing.Point(8, 15);
            this.textBoxTitleFolder.Multiline = true;
            this.textBoxTitleFolder.Name = "textBoxTitleFolder";
            this.textBoxTitleFolder.Size = new System.Drawing.Size(138, 36);
            this.textBoxTitleFolder.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(791, 420);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Задание 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(791, 420);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Задание 3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(791, 420);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Задание 4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Button buttonCreateFileTask1;
        private TextBox textBoxTitleFile;
        private Button buttonCreateFolderTask1;
        private TextBox textBoxTitleFolder;
        private Button buttonFindSum;
        private TextBox textBoxResultTask1;
    }
}