﻿namespace lab2_winForm
{
    partial class AddEmployee
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
            this.checkedListBoxEmployees = new System.Windows.Forms.CheckedListBox();
            this.buttonAddEmployee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedListBoxEmployees
            // 
            this.checkedListBoxEmployees.FormattingEnabled = true;
            this.checkedListBoxEmployees.Location = new System.Drawing.Point(12, 12);
            this.checkedListBoxEmployees.Name = "checkedListBoxEmployees";
            this.checkedListBoxEmployees.Size = new System.Drawing.Size(573, 290);
            this.checkedListBoxEmployees.TabIndex = 0;
            // 
            // buttonAddEmployee
            // 
            this.buttonAddEmployee.Location = new System.Drawing.Point(12, 308);
            this.buttonAddEmployee.Name = "buttonAddEmployee";
            this.buttonAddEmployee.Size = new System.Drawing.Size(121, 41);
            this.buttonAddEmployee.TabIndex = 1;
            this.buttonAddEmployee.Text = "Добавить";
            this.buttonAddEmployee.UseVisualStyleBackColor = true;
            this.buttonAddEmployee.Click += new System.EventHandler(this.buttonAddEmployee_Click);
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(597, 357);
            this.Controls.Add(this.buttonAddEmployee);
            this.Controls.Add(this.checkedListBoxEmployees);
            this.Name = "AddEmployee";
            this.Text = "AddEmployee";
            this.ResumeLayout(false);

        }

        #endregion

        private CheckedListBox checkedListBoxEmployees;
        private Button buttonAddEmployee;
    }
}