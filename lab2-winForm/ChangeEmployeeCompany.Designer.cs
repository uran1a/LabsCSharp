namespace lab2_winForm
{
    partial class ChangeEmployeeCompany<T>
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
            this.listViewChangeEmployeeCompany = new System.Windows.Forms.ListView();
            this.buttonChangeEmployeeCompany = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewChangeEmployeeCompany
            // 
            this.listViewChangeEmployeeCompany.Location = new System.Drawing.Point(12, 12);
            this.listViewChangeEmployeeCompany.Name = "listViewChangeEmployeeCompany";
            this.listViewChangeEmployeeCompany.Size = new System.Drawing.Size(578, 273);
            this.listViewChangeEmployeeCompany.TabIndex = 0;
            this.listViewChangeEmployeeCompany.UseCompatibleStateImageBehavior = false;
            // 
            // buttonChangeEmployeeCompany
            // 
            this.buttonChangeEmployeeCompany.Location = new System.Drawing.Point(12, 291);
            this.buttonChangeEmployeeCompany.Name = "buttonChangeEmployeeCompany";
            this.buttonChangeEmployeeCompany.Size = new System.Drawing.Size(127, 44);
            this.buttonChangeEmployeeCompany.TabIndex = 1;
            this.buttonChangeEmployeeCompany.Text = "Изменить";
            this.buttonChangeEmployeeCompany.UseVisualStyleBackColor = true;
            this.buttonChangeEmployeeCompany.Click += new System.EventHandler(this.buttonChangeEmployeeCompany_Click);
            // 
            // ChangeEmployeeCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(602, 342);
            this.Controls.Add(this.buttonChangeEmployeeCompany);
            this.Controls.Add(this.listViewChangeEmployeeCompany);
            this.Name = "ChangeEmployeeCompany";
            this.Text = "ChangeEmployeeCompany";
            this.ResumeLayout(false);

        }

        #endregion

        private ListView listViewChangeEmployeeCompany;
        private Button buttonChangeEmployeeCompany;
    }
}