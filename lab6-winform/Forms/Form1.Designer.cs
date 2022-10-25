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
            this.textBoxTask1 = new System.Windows.Forms.TextBox();
            this.checkedListBoxTask1 = new System.Windows.Forms.CheckedListBox();
            this.buttonClearTask1 = new System.Windows.Forms.Button();
            this.buttonRemoveTask1 = new System.Windows.Forms.Button();
            this.buttonSortTask1 = new System.Windows.Forms.Button();
            this.buttonInsertTask1 = new System.Windows.Forms.Button();
            this.buttonAddTask1 = new System.Windows.Forms.Button();
            this.listViewTask1 = new System.Windows.Forms.ListView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPop = new System.Windows.Forms.Button();
            this.buttonPush = new System.Windows.Forms.Button();
            this.textBoxPop = new System.Windows.Forms.TextBox();
            this.textBoxPush = new System.Windows.Forms.TextBox();
            this.textBoxStack = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(491, 324);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBoxTask1);
            this.tabPage1.Controls.Add(this.checkedListBoxTask1);
            this.tabPage1.Controls.Add(this.buttonClearTask1);
            this.tabPage1.Controls.Add(this.buttonRemoveTask1);
            this.tabPage1.Controls.Add(this.buttonSortTask1);
            this.tabPage1.Controls.Add(this.buttonInsertTask1);
            this.tabPage1.Controls.Add(this.buttonAddTask1);
            this.tabPage1.Controls.Add(this.listViewTask1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(483, 296);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Задание 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBoxTask1
            // 
            this.textBoxTask1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxTask1.Location = new System.Drawing.Point(310, 132);
            this.textBoxTask1.Multiline = true;
            this.textBoxTask1.Name = "textBoxTask1";
            this.textBoxTask1.Size = new System.Drawing.Size(81, 36);
            this.textBoxTask1.TabIndex = 8;
            // 
            // checkedListBoxTask1
            // 
            this.checkedListBoxTask1.FormattingEnabled = true;
            this.checkedListBoxTask1.Location = new System.Drawing.Point(311, 8);
            this.checkedListBoxTask1.Name = "checkedListBoxTask1";
            this.checkedListBoxTask1.Size = new System.Drawing.Size(167, 76);
            this.checkedListBoxTask1.TabIndex = 7;
            // 
            // buttonClearTask1
            // 
            this.buttonClearTask1.Location = new System.Drawing.Point(397, 174);
            this.buttonClearTask1.Name = "buttonClearTask1";
            this.buttonClearTask1.Size = new System.Drawing.Size(81, 36);
            this.buttonClearTask1.TabIndex = 5;
            this.buttonClearTask1.Text = "Clear";
            this.buttonClearTask1.UseVisualStyleBackColor = true;
            this.buttonClearTask1.Click += new System.EventHandler(this.buttonClearTask1_Click);
            // 
            // buttonRemoveTask1
            // 
            this.buttonRemoveTask1.Location = new System.Drawing.Point(310, 174);
            this.buttonRemoveTask1.Name = "buttonRemoveTask1";
            this.buttonRemoveTask1.Size = new System.Drawing.Size(81, 36);
            this.buttonRemoveTask1.TabIndex = 4;
            this.buttonRemoveTask1.Text = "Remove";
            this.buttonRemoveTask1.UseVisualStyleBackColor = true;
            this.buttonRemoveTask1.Click += new System.EventHandler(this.buttonRemoveTask1_Click);
            // 
            // buttonSortTask1
            // 
            this.buttonSortTask1.Location = new System.Drawing.Point(397, 90);
            this.buttonSortTask1.Name = "buttonSortTask1";
            this.buttonSortTask1.Size = new System.Drawing.Size(81, 36);
            this.buttonSortTask1.TabIndex = 3;
            this.buttonSortTask1.Text = "Sort";
            this.buttonSortTask1.UseVisualStyleBackColor = true;
            this.buttonSortTask1.Click += new System.EventHandler(this.buttonSortTask1_Click);
            // 
            // buttonInsertTask1
            // 
            this.buttonInsertTask1.Location = new System.Drawing.Point(397, 132);
            this.buttonInsertTask1.Name = "buttonInsertTask1";
            this.buttonInsertTask1.Size = new System.Drawing.Size(81, 36);
            this.buttonInsertTask1.TabIndex = 2;
            this.buttonInsertTask1.Text = "Insert";
            this.buttonInsertTask1.UseVisualStyleBackColor = true;
            this.buttonInsertTask1.Click += new System.EventHandler(this.buttonInsertTask1_Click);
            // 
            // buttonAddTask1
            // 
            this.buttonAddTask1.Location = new System.Drawing.Point(310, 88);
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
            this.tabPage2.Size = new System.Drawing.Size(483, 296);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Задание 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.buttonPop);
            this.tabPage3.Controls.Add(this.buttonPush);
            this.tabPage3.Controls.Add(this.textBoxPop);
            this.tabPage3.Controls.Add(this.textBoxPush);
            this.tabPage3.Controls.Add(this.textBoxStack);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(483, 296);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Задание 3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(160, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Введите значение в Stack:";
            // 
            // buttonPop
            // 
            this.buttonPop.Location = new System.Drawing.Point(160, 125);
            this.buttonPop.Name = "buttonPop";
            this.buttonPop.Size = new System.Drawing.Size(85, 31);
            this.buttonPop.TabIndex = 4;
            this.buttonPop.Text = "Pop";
            this.buttonPop.UseVisualStyleBackColor = true;
            this.buttonPop.Click += new System.EventHandler(this.buttonPop_Click);
            // 
            // buttonPush
            // 
            this.buttonPush.Location = new System.Drawing.Point(160, 59);
            this.buttonPush.Name = "buttonPush";
            this.buttonPush.Size = new System.Drawing.Size(85, 31);
            this.buttonPush.TabIndex = 3;
            this.buttonPush.Text = "Push";
            this.buttonPush.UseVisualStyleBackColor = true;
            this.buttonPush.Click += new System.EventHandler(this.buttonPush_Click);
            // 
            // textBoxPop
            // 
            this.textBoxPop.Location = new System.Drawing.Point(160, 96);
            this.textBoxPop.Name = "textBoxPop";
            this.textBoxPop.Size = new System.Drawing.Size(114, 23);
            this.textBoxPop.TabIndex = 2;
            // 
            // textBoxPush
            // 
            this.textBoxPush.Location = new System.Drawing.Point(160, 30);
            this.textBoxPush.Name = "textBoxPush";
            this.textBoxPush.Size = new System.Drawing.Size(114, 23);
            this.textBoxPush.TabIndex = 1;
            // 
            // textBoxStack
            // 
            this.textBoxStack.Location = new System.Drawing.Point(0, 0);
            this.textBoxStack.Multiline = true;
            this.textBoxStack.Name = "textBoxStack";
            this.textBoxStack.Size = new System.Drawing.Size(154, 196);
            this.textBoxStack.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 379);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
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
        private TextBox textBoxTask1;
        private CheckedListBox checkedListBoxTask1;
        private Button buttonPush;
        private TextBox textBoxPop;
        private TextBox textBoxPush;
        private TextBox textBoxStack;
        private Button buttonPop;
        private Label label1;
    }
}