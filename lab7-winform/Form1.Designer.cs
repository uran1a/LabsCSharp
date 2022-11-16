namespace lab7_winform
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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonSwapTask3 = new System.Windows.Forms.Button();
            this.textBoxNum2 = new System.Windows.Forms.TextBox();
            this.textBoxNum1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.labelX1 = new System.Windows.Forms.Label();
            this.textBoxX1 = new System.Windows.Forms.TextBox();
            this.textBoxY1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxY2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxX2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxY3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxX3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonCalculatePerimeter = new System.Windows.Forms.Button();
            this.textBoxPerimeterTask4 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(802, 453);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(794, 425);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Задание 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(794, 425);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Задание 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttonSwapTask3);
            this.tabPage3.Controls.Add(this.textBoxNum2);
            this.tabPage3.Controls.Add(this.textBoxNum1);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(794, 425);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Задание 3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonSwapTask3
            // 
            this.buttonSwapTask3.Location = new System.Drawing.Point(165, 24);
            this.buttonSwapTask3.Name = "buttonSwapTask3";
            this.buttonSwapTask3.Size = new System.Drawing.Size(80, 31);
            this.buttonSwapTask3.TabIndex = 4;
            this.buttonSwapTask3.Text = "Поменять";
            this.buttonSwapTask3.UseVisualStyleBackColor = true;
            this.buttonSwapTask3.Click += new System.EventHandler(this.buttonSwapTask3_Click);
            // 
            // textBoxNum2
            // 
            this.textBoxNum2.Location = new System.Drawing.Point(59, 40);
            this.textBoxNum2.Name = "textBoxNum2";
            this.textBoxNum2.Size = new System.Drawing.Size(100, 23);
            this.textBoxNum2.TabIndex = 3;
            // 
            // textBoxNum1
            // 
            this.textBoxNum1.Location = new System.Drawing.Point(59, 11);
            this.textBoxNum1.Name = "textBoxNum1";
            this.textBoxNum1.Size = new System.Drawing.Size(100, 23);
            this.textBoxNum1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "num2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "num1";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.textBoxPerimeterTask4);
            this.tabPage4.Controls.Add(this.buttonCalculatePerimeter);
            this.tabPage4.Controls.Add(this.textBoxY3);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.textBoxX3);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.textBoxY2);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.textBoxX2);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.textBoxY1);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.textBoxX1);
            this.tabPage4.Controls.Add(this.labelX1);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(794, 425);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Задание 4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.Location = new System.Drawing.Point(9, 11);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(19, 15);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "x1";
            // 
            // textBoxX1
            // 
            this.textBoxX1.Location = new System.Drawing.Point(34, 8);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.Size = new System.Drawing.Size(71, 23);
            this.textBoxX1.TabIndex = 1;
            // 
            // textBoxY1
            // 
            this.textBoxY1.Location = new System.Drawing.Point(34, 37);
            this.textBoxY1.Name = "textBoxY1";
            this.textBoxY1.Size = new System.Drawing.Size(71, 23);
            this.textBoxY1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "y1";
            // 
            // textBoxY2
            // 
            this.textBoxY2.Location = new System.Drawing.Point(147, 37);
            this.textBoxY2.Name = "textBoxY2";
            this.textBoxY2.Size = new System.Drawing.Size(71, 23);
            this.textBoxY2.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(122, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "y2";
            // 
            // textBoxX2
            // 
            this.textBoxX2.Location = new System.Drawing.Point(147, 8);
            this.textBoxX2.Name = "textBoxX2";
            this.textBoxX2.Size = new System.Drawing.Size(71, 23);
            this.textBoxX2.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(122, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "x2";
            // 
            // textBoxY3
            // 
            this.textBoxY3.Location = new System.Drawing.Point(261, 37);
            this.textBoxY3.Name = "textBoxY3";
            this.textBoxY3.Size = new System.Drawing.Size(71, 23);
            this.textBoxY3.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(236, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "y3";
            // 
            // textBoxX3
            // 
            this.textBoxX3.Location = new System.Drawing.Point(261, 8);
            this.textBoxX3.Name = "textBoxX3";
            this.textBoxX3.Size = new System.Drawing.Size(71, 23);
            this.textBoxX3.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(236, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "x3";
            // 
            // buttonCalculatePerimeter
            // 
            this.buttonCalculatePerimeter.Location = new System.Drawing.Point(122, 75);
            this.buttonCalculatePerimeter.Name = "buttonCalculatePerimeter";
            this.buttonCalculatePerimeter.Size = new System.Drawing.Size(148, 31);
            this.buttonCalculatePerimeter.TabIndex = 12;
            this.buttonCalculatePerimeter.Text = "Вычислить периметр";
            this.buttonCalculatePerimeter.UseVisualStyleBackColor = true;
            this.buttonCalculatePerimeter.Click += new System.EventHandler(this.buttonCalculatePerimeter_Click);
            // 
            // textBoxPerimeterTask4
            // 
            this.textBoxPerimeterTask4.Location = new System.Drawing.Point(9, 75);
            this.textBoxPerimeterTask4.Multiline = true;
            this.textBoxPerimeterTask4.Name = "textBoxPerimeterTask4";
            this.textBoxPerimeterTask4.Size = new System.Drawing.Size(107, 31);
            this.textBoxPerimeterTask4.TabIndex = 13;
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
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Button buttonSwapTask3;
        private TextBox textBoxNum2;
        private TextBox textBoxNum1;
        private Label label2;
        private Label label1;
        private TextBox textBoxY3;
        private Label label7;
        private TextBox textBoxX3;
        private Label label8;
        private TextBox textBoxY2;
        private Label label5;
        private TextBox textBoxX2;
        private Label label6;
        private TextBox textBoxY1;
        private Label label4;
        private TextBox textBoxX1;
        private Label labelX1;
        private TextBox textBoxPerimeterTask4;
        private Button buttonCalculatePerimeter;
    }
}