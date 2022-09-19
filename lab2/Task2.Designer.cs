namespace lab2
{
    partial class Task2
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
            this.titleCompany = new System.Windows.Forms.Label();
            this.labelDirectorCompany = new System.Windows.Forms.Label();
            this.labelAccountantCompany = new System.Windows.Forms.Label();
            this.labelGuardCompany = new System.Windows.Forms.Label();
            this.listViewEmployees = new System.Windows.Forms.ListView();
            this.buttonAddEmployee = new System.Windows.Forms.Button();
            this.buttonRemoveEmployee = new System.Windows.Forms.Button();
            this.buttonChangeDirectorCompany = new System.Windows.Forms.Button();
            this.textBoxDirectorCompany = new System.Windows.Forms.TextBox();
            this.textBoxGuardCompany = new System.Windows.Forms.TextBox();
            this.textBoxAccountantCompany = new System.Windows.Forms.TextBox();
            this.buttonChangeGuardCompany = new System.Windows.Forms.Button();
            this.buttonChangeAccountantCompany = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleCompany
            // 
            this.titleCompany.AutoSize = true;
            this.titleCompany.BackColor = System.Drawing.Color.White;
            this.titleCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.titleCompany.ForeColor = System.Drawing.Color.Black;
            this.titleCompany.Location = new System.Drawing.Point(12, 9);
            this.titleCompany.Name = "titleCompany";
            this.titleCompany.Size = new System.Drawing.Size(267, 31);
            this.titleCompany.TabIndex = 0;
            this.titleCompany.Text = "Название компании";
            // 
            // labelDirectorCompany
            // 
            this.labelDirectorCompany.AutoSize = true;
            this.labelDirectorCompany.BackColor = System.Drawing.Color.White;
            this.labelDirectorCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.labelDirectorCompany.ForeColor = System.Drawing.Color.Black;
            this.labelDirectorCompany.Location = new System.Drawing.Point(12, 57);
            this.labelDirectorCompany.Name = "labelDirectorCompany";
            this.labelDirectorCompany.Size = new System.Drawing.Size(129, 30);
            this.labelDirectorCompany.TabIndex = 1;
            this.labelDirectorCompany.Text = "Директор";
            // 
            // labelAccountantCompany
            // 
            this.labelAccountantCompany.AutoSize = true;
            this.labelAccountantCompany.BackColor = System.Drawing.Color.White;
            this.labelAccountantCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.labelAccountantCompany.ForeColor = System.Drawing.Color.Black;
            this.labelAccountantCompany.Location = new System.Drawing.Point(13, 104);
            this.labelAccountantCompany.Name = "labelAccountantCompany";
            this.labelAccountantCompany.Size = new System.Drawing.Size(134, 30);
            this.labelAccountantCompany.TabIndex = 2;
            this.labelAccountantCompany.Text = "Бухгалтер";
            // 
            // labelGuardCompany
            // 
            this.labelGuardCompany.AutoSize = true;
            this.labelGuardCompany.BackColor = System.Drawing.Color.White;
            this.labelGuardCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.labelGuardCompany.ForeColor = System.Drawing.Color.Black;
            this.labelGuardCompany.Location = new System.Drawing.Point(13, 149);
            this.labelGuardCompany.Name = "labelGuardCompany";
            this.labelGuardCompany.Size = new System.Drawing.Size(115, 30);
            this.labelGuardCompany.TabIndex = 3;
            this.labelGuardCompany.Text = "Охраник";
            // 
            // listViewEmployees
            // 
            this.listViewEmployees.HideSelection = false;
            this.listViewEmployees.Location = new System.Drawing.Point(12, 192);
            this.listViewEmployees.Name = "listViewEmployees";
            this.listViewEmployees.Size = new System.Drawing.Size(587, 206);
            this.listViewEmployees.TabIndex = 4;
            this.listViewEmployees.UseCompatibleStateImageBehavior = false;
            // 
            // buttonAddEmployee
            // 
            this.buttonAddEmployee.BackColor = System.Drawing.Color.LightGreen;
            this.buttonAddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonAddEmployee.ForeColor = System.Drawing.Color.Black;
            this.buttonAddEmployee.Location = new System.Drawing.Point(12, 404);
            this.buttonAddEmployee.Name = "buttonAddEmployee";
            this.buttonAddEmployee.Size = new System.Drawing.Size(91, 34);
            this.buttonAddEmployee.TabIndex = 5;
            this.buttonAddEmployee.Text = "Добавить";
            this.buttonAddEmployee.UseVisualStyleBackColor = false;
            // 
            // buttonRemoveEmployee
            // 
            this.buttonRemoveEmployee.BackColor = System.Drawing.Color.LightCoral;
            this.buttonRemoveEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonRemoveEmployee.Location = new System.Drawing.Point(109, 404);
            this.buttonRemoveEmployee.Name = "buttonRemoveEmployee";
            this.buttonRemoveEmployee.Size = new System.Drawing.Size(91, 34);
            this.buttonRemoveEmployee.TabIndex = 6;
            this.buttonRemoveEmployee.Text = "Уволить";
            this.buttonRemoveEmployee.UseVisualStyleBackColor = false;
            // 
            // buttonChangeDirectorCompany
            // 
            this.buttonChangeDirectorCompany.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonChangeDirectorCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonChangeDirectorCompany.ForeColor = System.Drawing.Color.Black;
            this.buttonChangeDirectorCompany.Location = new System.Drawing.Point(355, 57);
            this.buttonChangeDirectorCompany.Name = "buttonChangeDirectorCompany";
            this.buttonChangeDirectorCompany.Size = new System.Drawing.Size(91, 34);
            this.buttonChangeDirectorCompany.TabIndex = 12;
            this.buttonChangeDirectorCompany.Text = "Изменить";
            this.buttonChangeDirectorCompany.UseVisualStyleBackColor = false;
            // 
            // textBoxDirectorCompany
            // 
            this.textBoxDirectorCompany.Location = new System.Drawing.Point(161, 57);
            this.textBoxDirectorCompany.Multiline = true;
            this.textBoxDirectorCompany.Name = "textBoxDirectorCompany";
            this.textBoxDirectorCompany.Size = new System.Drawing.Size(180, 30);
            this.textBoxDirectorCompany.TabIndex = 7;
            // 
            // textBoxGuardCompany
            // 
            this.textBoxGuardCompany.Location = new System.Drawing.Point(161, 149);
            this.textBoxGuardCompany.Multiline = true;
            this.textBoxGuardCompany.Name = "textBoxGuardCompany";
            this.textBoxGuardCompany.Size = new System.Drawing.Size(180, 30);
            this.textBoxGuardCompany.TabIndex = 14;
            // 
            // textBoxAccountantCompany
            // 
            this.textBoxAccountantCompany.Location = new System.Drawing.Point(161, 104);
            this.textBoxAccountantCompany.Multiline = true;
            this.textBoxAccountantCompany.Name = "textBoxAccountantCompany";
            this.textBoxAccountantCompany.Size = new System.Drawing.Size(180, 30);
            this.textBoxAccountantCompany.TabIndex = 15;
            // 
            // buttonChangeGuardCompany
            // 
            this.buttonChangeGuardCompany.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonChangeGuardCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonChangeGuardCompany.ForeColor = System.Drawing.Color.Black;
            this.buttonChangeGuardCompany.Location = new System.Drawing.Point(355, 145);
            this.buttonChangeGuardCompany.Name = "buttonChangeGuardCompany";
            this.buttonChangeGuardCompany.Size = new System.Drawing.Size(91, 34);
            this.buttonChangeGuardCompany.TabIndex = 16;
            this.buttonChangeGuardCompany.Text = "Изменить";
            this.buttonChangeGuardCompany.UseVisualStyleBackColor = false;
            // 
            // buttonChangeAccountantCompany
            // 
            this.buttonChangeAccountantCompany.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonChangeAccountantCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonChangeAccountantCompany.ForeColor = System.Drawing.Color.Black;
            this.buttonChangeAccountantCompany.Location = new System.Drawing.Point(355, 104);
            this.buttonChangeAccountantCompany.Name = "buttonChangeAccountantCompany";
            this.buttonChangeAccountantCompany.Size = new System.Drawing.Size(91, 34);
            this.buttonChangeAccountantCompany.TabIndex = 17;
            this.buttonChangeAccountantCompany.Text = "Изменить";
            this.buttonChangeAccountantCompany.UseVisualStyleBackColor = false;
            // 
            // Task2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonChangeAccountantCompany);
            this.Controls.Add(this.buttonChangeGuardCompany);
            this.Controls.Add(this.textBoxAccountantCompany);
            this.Controls.Add(this.textBoxGuardCompany);
            this.Controls.Add(this.buttonChangeDirectorCompany);
            this.Controls.Add(this.textBoxDirectorCompany);
            this.Controls.Add(this.buttonRemoveEmployee);
            this.Controls.Add(this.buttonAddEmployee);
            this.Controls.Add(this.listViewEmployees);
            this.Controls.Add(this.labelGuardCompany);
            this.Controls.Add(this.labelAccountantCompany);
            this.Controls.Add(this.labelDirectorCompany);
            this.Controls.Add(this.titleCompany);
            this.Name = "Task2";
            this.Text = "Task2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleCompany;
        private System.Windows.Forms.Label labelDirectorCompany;
        private System.Windows.Forms.Label labelAccountantCompany;
        private System.Windows.Forms.Label labelGuardCompany;
        private System.Windows.Forms.ListView listViewEmployees;
        private System.Windows.Forms.Button buttonAddEmployee;
        private System.Windows.Forms.Button buttonRemoveEmployee;
        private System.Windows.Forms.Button buttonChangeDirectorCompany;
        private System.Windows.Forms.TextBox textBoxDirectorCompany;
        private System.Windows.Forms.TextBox textBoxGuardCompany;
        private System.Windows.Forms.TextBox textBoxAccountantCompany;
        private System.Windows.Forms.Button buttonChangeGuardCompany;
        private System.Windows.Forms.Button buttonChangeAccountantCompany;
    }
}