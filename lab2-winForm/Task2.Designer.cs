namespace lab2_winForm
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
            this.labelTitleCompany = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelDirectorCompany = new System.Windows.Forms.Label();
            this.labelAccountentCompany = new System.Windows.Forms.Label();
            this.labelDGuardCompany = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listViewEmployees = new System.Windows.Forms.ListView();
            this.buttonChangeDirectorCompany = new System.Windows.Forms.Button();
            this.buttonChangeGuardCompany = new System.Windows.Forms.Button();
            this.buttonAccountantCompany = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitleCompany
            // 
            this.labelTitleCompany.AutoSize = true;
            this.labelTitleCompany.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitleCompany.Location = new System.Drawing.Point(12, 9);
            this.labelTitleCompany.Name = "labelTitleCompany";
            this.labelTitleCompany.Size = new System.Drawing.Size(336, 46);
            this.labelTitleCompany.TabIndex = 0;
            this.labelTitleCompany.Text = "Название компании";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Директор";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "Бухгалтер";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 35);
            this.label3.TabIndex = 3;
            this.label3.Text = "Охранник";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDirectorCompany
            // 
            this.labelDirectorCompany.AutoSize = true;
            this.labelDirectorCompany.BackColor = System.Drawing.Color.White;
            this.labelDirectorCompany.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDirectorCompany.Location = new System.Drawing.Point(145, 101);
            this.labelDirectorCompany.Name = "labelDirectorCompany";
            this.labelDirectorCompany.Size = new System.Drawing.Size(71, 35);
            this.labelDirectorCompany.TabIndex = 4;
            this.labelDirectorCompany.Text = "ФИО";
            this.labelDirectorCompany.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAccountentCompany
            // 
            this.labelAccountentCompany.AutoSize = true;
            this.labelAccountentCompany.BackColor = System.Drawing.Color.White;
            this.labelAccountentCompany.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAccountentCompany.Location = new System.Drawing.Point(145, 149);
            this.labelAccountentCompany.Name = "labelAccountentCompany";
            this.labelAccountentCompany.Size = new System.Drawing.Size(71, 35);
            this.labelAccountentCompany.TabIndex = 5;
            this.labelAccountentCompany.Text = "ФИО";
            this.labelAccountentCompany.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDGuardCompany
            // 
            this.labelDGuardCompany.AutoSize = true;
            this.labelDGuardCompany.BackColor = System.Drawing.Color.White;
            this.labelDGuardCompany.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDGuardCompany.Location = new System.Drawing.Point(146, 195);
            this.labelDGuardCompany.Name = "labelDGuardCompany";
            this.labelDGuardCompany.Size = new System.Drawing.Size(71, 35);
            this.labelDGuardCompany.TabIndex = 6;
            this.labelDGuardCompany.Text = "ФИО";
            this.labelDGuardCompany.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 35);
            this.label4.TabIndex = 7;
            this.label4.Text = "Сотрудники";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listViewEmployees
            // 
            this.listViewEmployees.Location = new System.Drawing.Point(12, 280);
            this.listViewEmployees.Name = "listViewEmployees";
            this.listViewEmployees.Size = new System.Drawing.Size(776, 321);
            this.listViewEmployees.TabIndex = 8;
            this.listViewEmployees.UseCompatibleStateImageBehavior = false;
            // 
            // buttonChangeDirectorCompany
            // 
            this.buttonChangeDirectorCompany.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonChangeDirectorCompany.Location = new System.Drawing.Point(569, 104);
            this.buttonChangeDirectorCompany.Name = "buttonChangeDirectorCompany";
            this.buttonChangeDirectorCompany.Size = new System.Drawing.Size(143, 37);
            this.buttonChangeDirectorCompany.TabIndex = 9;
            this.buttonChangeDirectorCompany.Text = "Изменить";
            this.buttonChangeDirectorCompany.UseVisualStyleBackColor = true;
            this.buttonChangeDirectorCompany.Click += new System.EventHandler(this.buttonChangeDirectorCompany_Click);
            // 
            // buttonChangeGuardCompany
            // 
            this.buttonChangeGuardCompany.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonChangeGuardCompany.Location = new System.Drawing.Point(569, 190);
            this.buttonChangeGuardCompany.Name = "buttonChangeGuardCompany";
            this.buttonChangeGuardCompany.Size = new System.Drawing.Size(143, 37);
            this.buttonChangeGuardCompany.TabIndex = 10;
            this.buttonChangeGuardCompany.Text = "Изменить";
            this.buttonChangeGuardCompany.UseVisualStyleBackColor = true;
            // 
            // buttonAccountantCompany
            // 
            this.buttonAccountantCompany.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAccountantCompany.Location = new System.Drawing.Point(569, 147);
            this.buttonAccountantCompany.Name = "buttonAccountantCompany";
            this.buttonAccountantCompany.Size = new System.Drawing.Size(143, 37);
            this.buttonAccountantCompany.TabIndex = 11;
            this.buttonAccountantCompany.Text = "Изменить";
            this.buttonAccountantCompany.UseVisualStyleBackColor = true;
            // 
            // Task2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 613);
            this.Controls.Add(this.buttonAccountantCompany);
            this.Controls.Add(this.buttonChangeGuardCompany);
            this.Controls.Add(this.buttonChangeDirectorCompany);
            this.Controls.Add(this.listViewEmployees);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelDGuardCompany);
            this.Controls.Add(this.labelAccountentCompany);
            this.Controls.Add(this.labelDirectorCompany);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTitleCompany);
            this.Name = "Task2";
            this.Text = "Task2";
            this.Activated += new System.EventHandler(this.Task2_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelTitleCompany;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label labelDirectorCompany;
        private Label labelAccountentCompany;
        private Label labelDGuardCompany;
        private Label label4;
        private ListView listViewEmployees;
        private Button buttonChangeDirectorCompany;
        private Button buttonChangeGuardCompany;
        private Button buttonAccountantCompany;
    }
}