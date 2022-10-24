namespace lab6_winform
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
            this.buttonAddTask1 = new System.Windows.Forms.Button();
            this.listViewTask1 = new System.Windows.Forms.ListView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonInsertTask1 = new System.Windows.Forms.Button();
            this.buttonSortTask1 = new System.Windows.Forms.Button();
            this.buttonRemoveTask1 = new System.Windows.Forms.Button();
            this.buttonClearTask1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(565, 379);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonClearTask1);
            this.tabPage1.Controls.Add(this.buttonRemoveTask1);
            this.tabPage1.Controls.Add(this.buttonSortTask1);
            this.tabPage1.Controls.Add(this.buttonInsertTask1);
            this.tabPage1.Controls.Add(this.buttonAddTask1);
            this.tabPage1.Controls.Add(this.listViewTask1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(557, 351);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Задание 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonAddTask1
            // 
            this.buttonAddTask1.Location = new System.Drawing.Point(310, 8);
            this.buttonAddTask1.Name = "buttonAddTask1";
            this.buttonAddTask1.Size = new System.Drawing.Size(81, 36);
            this.buttonAddTask1.TabIndex = 1;
            this.buttonAddTask1.Text = "Add";
            this.buttonAddTask1.UseVisualStyleBackColor = true;
            this.buttonAddTask1.Click += new System.EventHandler(this.buttonAddTask1_Click);
            // 
            // listViewTask1
            // 
            this.listViewTask1.Location = new System.Drawing.Point(8, 8);
            this.listViewTask1.Name = "listViewTask1";
            this.listViewTask1.Size = new System.Drawing.Size(296, 284);
            this.listViewTask1.TabIndex = 0;
            this.listViewTask1.UseCompatibleStateImageBehavior = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(557, 351);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Задание 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(557, 351);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Задание 3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonInsertTask1
            // 
            this.buttonInsertTask1.Location = new System.Drawing.Point(310, 50);
            this.buttonInsertTask1.Name = "buttonInsertTask1";
            this.buttonInsertTask1.Size = new System.Drawing.Size(81, 36);
            this.buttonInsertTask1.TabIndex = 2;
            this.buttonInsertTask1.Text = "Insert";
            this.buttonInsertTask1.UseVisualStyleBackColor = true;
            this.buttonInsertTask1.Click += new System.EventHandler(this.buttonInsertTask1_Click);
            // 
            // buttonSortTask1
            // 
            this.buttonSortTask1.Location = new System.Drawing.Point(310, 92);
            this.buttonSortTask1.Name = "buttonSortTask1";
            this.buttonSortTask1.Size = new System.Drawing.Size(81, 36);
            this.buttonSortTask1.TabIndex = 3;
            this.buttonSortTask1.Text = "Sort";
            this.buttonSortTask1.UseVisualStyleBackColor = true;
            this.buttonSortTask1.Click += new System.EventHandler(this.buttonSortTask1_Click);
            // 
            // buttonRemoveTask1
            // 
            this.buttonRemoveTask1.Location = new System.Drawing.Point(310, 134);
            this.buttonRemoveTask1.Name = "buttonRemoveTask1";
            this.buttonRemoveTask1.Size = new System.Drawing.Size(81, 36);
            this.buttonRemoveTask1.TabIndex = 4;
            this.buttonRemoveTask1.Text = "Remove";
            this.buttonRemoveTask1.UseVisualStyleBackColor = true;
            this.buttonRemoveTask1.Click += new System.EventHandler(this.buttonRemoveTask1_Click);
            // 
            // buttonClearTask1
            // 
            this.buttonClearTask1.Location = new System.Drawing.Point(310, 176);
            this.buttonClearTask1.Name = "buttonClearTask1";
            this.buttonClearTask1.Size = new System.Drawing.Size(81, 36);
            this.buttonClearTask1.TabIndex = 5;
            this.buttonClearTask1.Text = "Clear";
            this.buttonClearTask1.UseVisualStyleBackColor = true;
            this.buttonClearTask1.Click += new System.EventHandler(this.buttonClearTask1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 379);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private ListView listViewTask1;
        private Button buttonAddTask1;
        private Button buttonSortTask1;
        private Button buttonInsertTask1;
        private Button buttonRemoveTask1;
        private Button buttonClearTask1;
    }
}