namespace launcher
{
    partial class launcher
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonStart = new System.Windows.Forms.Button();
            this.listViewLabs = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.treeViewLabs = new System.Windows.Forms.TreeView();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.treeViewLabs);
            this.panel1.Controls.Add(this.buttonStart);
            this.panel1.Controls.Add(this.listViewLabs);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(23, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(502, 554);
            this.panel1.TabIndex = 0;
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonStart.Location = new System.Drawing.Point(22, 491);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(138, 51);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Запуск";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // listViewLabs
            // 
            this.listViewLabs.Location = new System.Drawing.Point(22, 49);
            this.listViewLabs.Name = "listViewLabs";
            this.listViewLabs.Size = new System.Drawing.Size(460, 204);
            this.listViewLabs.TabIndex = 1;
            this.listViewLabs.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(74, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Лабораторные работы";
            // 
            // treeViewLabs
            // 
            this.treeViewLabs.Location = new System.Drawing.Point(22, 259);
            this.treeViewLabs.Name = "treeViewLabs";
            this.treeViewLabs.Size = new System.Drawing.Size(460, 226);
            this.treeViewLabs.TabIndex = 3;
            // 
            // launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(549, 578);
            this.Controls.Add(this.panel1);
            this.Name = "launcher";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button buttonStart;
        private ListView listViewLabs;
        private Label label1;
        private TreeView treeViewLabs;
    }
}