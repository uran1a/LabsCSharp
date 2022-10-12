namespace lab4_winform
{
    partial class MainForm
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
            this.labelAddTruck = new System.Windows.Forms.Label();
            this.buttonAddTruck = new System.Windows.Forms.Button();
            this.buttonAddHouse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddCargoPlane = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // labelAddTruck
            // 
            this.labelAddTruck.AutoSize = true;
            this.labelAddTruck.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAddTruck.Location = new System.Drawing.Point(18, 18);
            this.labelAddTruck.Name = "labelAddTruck";
            this.labelAddTruck.Size = new System.Drawing.Size(309, 28);
            this.labelAddTruck.TabIndex = 0;
            this.labelAddTruck.Text = "Добавить грузовой автомобиль";
            // 
            // buttonAddTruck
            // 
            this.buttonAddTruck.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddTruck.Location = new System.Drawing.Point(333, 12);
            this.buttonAddTruck.Name = "buttonAddTruck";
            this.buttonAddTruck.Size = new System.Drawing.Size(156, 44);
            this.buttonAddTruck.TabIndex = 1;
            this.buttonAddTruck.Text = "Добавить";
            this.buttonAddTruck.UseVisualStyleBackColor = true;
            this.buttonAddTruck.Click += new System.EventHandler(this.buttonAddTruck_Click);
            // 
            // buttonAddHouse
            // 
            this.buttonAddHouse.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddHouse.Location = new System.Drawing.Point(333, 126);
            this.buttonAddHouse.Name = "buttonAddHouse";
            this.buttonAddHouse.Size = new System.Drawing.Size(156, 44);
            this.buttonAddHouse.TabIndex = 3;
            this.buttonAddHouse.Text = "Добавить";
            this.buttonAddHouse.UseVisualStyleBackColor = true;
            this.buttonAddHouse.Click += new System.EventHandler(this.buttonAddHouse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(18, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Добавить грузовой автомобиль";
            // 
            // buttonAddCargoPlane
            // 
            this.buttonAddCargoPlane.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddCargoPlane.Location = new System.Drawing.Point(333, 68);
            this.buttonAddCargoPlane.Name = "buttonAddCargoPlane";
            this.buttonAddCargoPlane.Size = new System.Drawing.Size(156, 44);
            this.buttonAddCargoPlane.TabIndex = 5;
            this.buttonAddCargoPlane.Text = "Добавить";
            this.buttonAddCargoPlane.UseVisualStyleBackColor = true;
            this.buttonAddCargoPlane.Click += new System.EventHandler(this.buttonAddCargoPlane_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(18, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Добавить грузовой самолет";
            // 
            // listView
            // 
            this.listView.Location = new System.Drawing.Point(18, 182);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(770, 467);
            this.listView.TabIndex = 6;
            this.listView.UseCompatibleStateImageBehavior = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 661);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.buttonAddCargoPlane);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAddHouse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAddTruck);
            this.Controls.Add(this.labelAddTruck);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelAddTruck;
        private Button buttonAddTruck;
        private Button buttonAddHouse;
        private Label label1;
        private Button buttonAddCargoPlane;
        private Label label2;
        private ListView listView;
    }
}