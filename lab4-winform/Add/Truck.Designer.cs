﻿namespace lab4_winform.Add
{
    partial class Truck
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
            this.buttonAddTruck = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCargo = new System.Windows.Forms.TextBox();
            this.labelCargo = new System.Windows.Forms.Label();
            this.textBoxMaxWeight = new System.Windows.Forms.TextBox();
            this.labelMaxWeight = new System.Windows.Forms.Label();
            this.textBoxMileage = new System.Windows.Forms.TextBox();
            this.labelMileage = new System.Windows.Forms.Label();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.labelYear = new System.Windows.Forms.Label();
            this.textBoxBrand = new System.Windows.Forms.TextBox();
            this.labelBrand = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAddTruck
            // 
            this.buttonAddTruck.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddTruck.Location = new System.Drawing.Point(28, 309);
            this.buttonAddTruck.Name = "buttonAddTruck";
            this.buttonAddTruck.Size = new System.Drawing.Size(140, 52);
            this.buttonAddTruck.TabIndex = 23;
            this.buttonAddTruck.Text = "Добавить";
            this.buttonAddTruck.UseVisualStyleBackColor = true;
            this.buttonAddTruck.Click += new System.EventHandler(this.buttonAddTruck_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 38);
            this.label1.TabIndex = 22;
            this.label1.Text = "Грузовой автомобиль";
            // 
            // textBoxCargo
            // 
            this.textBoxCargo.Location = new System.Drawing.Point(133, 254);
            this.textBoxCargo.Name = "textBoxCargo";
            this.textBoxCargo.Size = new System.Drawing.Size(125, 27);
            this.textBoxCargo.TabIndex = 21;
            // 
            // labelCargo
            // 
            this.labelCargo.AutoSize = true;
            this.labelCargo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCargo.Location = new System.Drawing.Point(28, 250);
            this.labelCargo.Name = "labelCargo";
            this.labelCargo.Size = new System.Drawing.Size(52, 28);
            this.labelCargo.TabIndex = 20;
            this.labelCargo.Text = "Груз";
            // 
            // textBoxMaxWeight
            // 
            this.textBoxMaxWeight.Location = new System.Drawing.Point(133, 205);
            this.textBoxMaxWeight.Name = "textBoxMaxWeight";
            this.textBoxMaxWeight.Size = new System.Drawing.Size(125, 27);
            this.textBoxMaxWeight.TabIndex = 19;
            // 
            // labelMaxWeight
            // 
            this.labelMaxWeight.AutoSize = true;
            this.labelMaxWeight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMaxWeight.Location = new System.Drawing.Point(28, 201);
            this.labelMaxWeight.Name = "labelMaxWeight";
            this.labelMaxWeight.Size = new System.Drawing.Size(89, 28);
            this.labelMaxWeight.TabIndex = 18;
            this.labelMaxWeight.Text = "Мак. вес";
            // 
            // textBoxMileage
            // 
            this.textBoxMileage.Location = new System.Drawing.Point(133, 156);
            this.textBoxMileage.Name = "textBoxMileage";
            this.textBoxMileage.Size = new System.Drawing.Size(125, 27);
            this.textBoxMileage.TabIndex = 17;
            // 
            // labelMileage
            // 
            this.labelMileage.AutoSize = true;
            this.labelMileage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMileage.Location = new System.Drawing.Point(28, 152);
            this.labelMileage.Name = "labelMileage";
            this.labelMileage.Size = new System.Drawing.Size(80, 28);
            this.labelMileage.TabIndex = 16;
            this.labelMileage.Text = "Пробег";
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(133, 106);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(125, 27);
            this.textBoxYear.TabIndex = 15;
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelYear.Location = new System.Drawing.Point(28, 105);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(44, 28);
            this.labelYear.TabIndex = 14;
            this.labelYear.Text = "Год";
            // 
            // textBoxBrand
            // 
            this.textBoxBrand.Location = new System.Drawing.Point(133, 65);
            this.textBoxBrand.Name = "textBoxBrand";
            this.textBoxBrand.Size = new System.Drawing.Size(125, 27);
            this.textBoxBrand.TabIndex = 13;
            // 
            // labelBrand
            // 
            this.labelBrand.AutoSize = true;
            this.labelBrand.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelBrand.Location = new System.Drawing.Point(28, 61);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(72, 28);
            this.labelBrand.TabIndex = 12;
            this.labelBrand.Text = "Марка";
            // 
            // Truck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(355, 375);
            this.Controls.Add(this.buttonAddTruck);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCargo);
            this.Controls.Add(this.labelCargo);
            this.Controls.Add(this.textBoxMaxWeight);
            this.Controls.Add(this.labelMaxWeight);
            this.Controls.Add(this.textBoxMileage);
            this.Controls.Add(this.labelMileage);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.textBoxBrand);
            this.Controls.Add(this.labelBrand);
            this.Name = "Truck";
            this.Text = "Truck";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonAddTruck;
        private Label label1;
        private TextBox textBoxCargo;
        private Label labelCargo;
        private TextBox textBoxMaxWeight;
        private Label labelMaxWeight;
        private TextBox textBoxMileage;
        private Label labelMileage;
        private TextBox textBoxYear;
        private Label labelYear;
        private TextBox textBoxBrand;
        private Label labelBrand;
    }
}