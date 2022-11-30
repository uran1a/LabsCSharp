namespace lab9_winform
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
            this.buttonOpenFIleTask3 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBoxCopyFIle = new System.Windows.Forms.TextBox();
            this.buttonCopyFile = new System.Windows.Forms.Button();
            this.textBoxOpenFile = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBoxFileInformation = new System.Windows.Forms.TextBox();
            this.buttonOpenFIleTask4 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOpenFIleTask3
            // 
            this.buttonOpenFIleTask3.Location = new System.Drawing.Point(124, 6);
            this.buttonOpenFIleTask3.Name = "buttonOpenFIleTask3";
            this.buttonOpenFIleTask3.Size = new System.Drawing.Size(95, 35);
            this.buttonOpenFIleTask3.TabIndex = 0;
            this.buttonOpenFIleTask3.Text = "Открыть";
            this.buttonOpenFIleTask3.UseVisualStyleBackColor = true;
            this.buttonOpenFIleTask3.Click += new System.EventHandler(this.buttonOpenFIleTask3_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 448);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBoxCopyFIle);
            this.tabPage1.Controls.Add(this.buttonCopyFile);
            this.tabPage1.Controls.Add(this.textBoxOpenFile);
            this.tabPage1.Controls.Add(this.buttonOpenFIleTask3);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 420);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Задание 3";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBoxCopyFIle
            // 
            this.textBoxCopyFIle.Location = new System.Drawing.Point(8, 63);
            this.textBoxCopyFIle.Multiline = true;
            this.textBoxCopyFIle.Name = "textBoxCopyFIle";
            this.textBoxCopyFIle.Size = new System.Drawing.Size(110, 35);
            this.textBoxCopyFIle.TabIndex = 3;
            // 
            // buttonCopyFile
            // 
            this.buttonCopyFile.Location = new System.Drawing.Point(124, 63);
            this.buttonCopyFile.Name = "buttonCopyFile";
            this.buttonCopyFile.Size = new System.Drawing.Size(95, 35);
            this.buttonCopyFile.TabIndex = 2;
            this.buttonCopyFile.Text = "Копировать";
            this.buttonCopyFile.UseVisualStyleBackColor = true;
            this.buttonCopyFile.Click += new System.EventHandler(this.buttonCopyFile_Click);
            // 
            // textBoxOpenFile
            // 
            this.textBoxOpenFile.Location = new System.Drawing.Point(8, 6);
            this.textBoxOpenFile.Multiline = true;
            this.textBoxOpenFile.Name = "textBoxOpenFile";
            this.textBoxOpenFile.Size = new System.Drawing.Size(110, 35);
            this.textBoxOpenFile.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBoxFileInformation);
            this.tabPage2.Controls.Add(this.buttonOpenFIleTask4);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 420);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Задание 4";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBoxFileInformation
            // 
            this.textBoxFileInformation.Location = new System.Drawing.Point(8, 47);
            this.textBoxFileInformation.Multiline = true;
            this.textBoxFileInformation.Name = "textBoxFileInformation";
            this.textBoxFileInformation.Size = new System.Drawing.Size(362, 138);
            this.textBoxFileInformation.TabIndex = 3;
            // 
            // buttonOpenFIleTask4
            // 
            this.buttonOpenFIleTask4.Location = new System.Drawing.Point(8, 6);
            this.buttonOpenFIleTask4.Name = "buttonOpenFIleTask4";
            this.buttonOpenFIleTask4.Size = new System.Drawing.Size(95, 35);
            this.buttonOpenFIleTask4.TabIndex = 2;
            this.buttonOpenFIleTask4.Text = "Открыть";
            this.buttonOpenFIleTask4.UseVisualStyleBackColor = true;
            this.buttonOpenFIleTask4.Click += new System.EventHandler(this.buttonOpenFIleTask4_Click);
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
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonOpenFIleTask3;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox textBoxCopyFIle;
        private Button buttonCopyFile;
        private TextBox textBoxOpenFile;
        private TextBox textBoxFileInformation;
        private Button buttonOpenFIleTask4;
    }
}