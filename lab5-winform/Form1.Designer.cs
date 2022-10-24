namespace lab5_winform
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTask2 = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonComputationTask2 = new System.Windows.Forms.Button();
            this.labelResultTask2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(788, 438);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(780, 410);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Задание 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.labelResultTask2);
            this.tabPage2.Controls.Add(this.buttonComputationTask2);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.textBoxTask2);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(780, 410);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Задание 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите последовательность, содержащую от 2 до 30 слов, в каждом из\r\nкоторых от 2" +
    " до 10 латинских букв; между соседними словами -- не\r\nменее одного пробела, за п" +
    "оследним словом - точка.";
            // 
            // textBoxTask2
            // 
            this.textBoxTask2.Location = new System.Drawing.Point(8, 58);
            this.textBoxTask2.Multiline = true;
            this.textBoxTask2.Name = "textBoxTask2";
            this.textBoxTask2.Size = new System.Drawing.Size(269, 105);
            this.textBoxTask2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(780, 410);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Задание 3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Слова без первой и последней буквы:";
            // 
            // buttonComputationTask2
            // 
            this.buttonComputationTask2.Location = new System.Drawing.Point(8, 169);
            this.buttonComputationTask2.Name = "buttonComputationTask2";
            this.buttonComputationTask2.Size = new System.Drawing.Size(123, 38);
            this.buttonComputationTask2.TabIndex = 3;
            this.buttonComputationTask2.Text = "Найти";
            this.buttonComputationTask2.UseVisualStyleBackColor = true;
            this.buttonComputationTask2.Click += new System.EventHandler(this.buttonComputationTask2_Click);
            // 
            // labelResultTask2
            // 
            this.labelResultTask2.AutoSize = true;
            this.labelResultTask2.Location = new System.Drawing.Point(8, 235);
            this.labelResultTask2.Name = "labelResultTask2";
            this.labelResultTask2.Size = new System.Drawing.Size(0, 15);
            this.labelResultTask2.TabIndex = 4;
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
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TextBox textBoxTask2;
        private Label label1;
        private Label labelResultTask2;
        private Button buttonComputationTask2;
        private Label label2;
    }
}