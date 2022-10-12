namespace lab4_winform.Add
{
    partial class House
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
            this.labelAddress = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxYearOfConstruction = new System.Windows.Forms.TextBox();
            this.labelYearOfConstruction = new System.Windows.Forms.Label();
            this.textBoxNumberOfFloors = new System.Windows.Forms.TextBox();
            this.labelNumberOfFloors = new System.Windows.Forms.Label();
            this.textBoxSquare = new System.Windows.Forms.TextBox();
            this.labelSquare = new System.Windows.Forms.Label();
            this.textBoxVolume = new System.Windows.Forms.TextBox();
            this.labelVolume = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddHouse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAddress.Location = new System.Drawing.Point(28, 61);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(67, 28);
            this.labelAddress.TabIndex = 0;
            this.labelAddress.Text = "Адрес";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(182, 62);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(125, 27);
            this.textBoxAddress.TabIndex = 1;
            // 
            // textBoxYearOfConstruction
            // 
            this.textBoxYearOfConstruction.Location = new System.Drawing.Point(182, 105);
            this.textBoxYearOfConstruction.Name = "textBoxYearOfConstruction";
            this.textBoxYearOfConstruction.Size = new System.Drawing.Size(125, 27);
            this.textBoxYearOfConstruction.TabIndex = 3;
            // 
            // labelYearOfConstruction
            // 
            this.labelYearOfConstruction.AutoSize = true;
            this.labelYearOfConstruction.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelYearOfConstruction.Location = new System.Drawing.Point(28, 105);
            this.labelYearOfConstruction.Name = "labelYearOfConstruction";
            this.labelYearOfConstruction.Size = new System.Drawing.Size(148, 28);
            this.labelYearOfConstruction.TabIndex = 2;
            this.labelYearOfConstruction.Text = "Год постройки";
            // 
            // textBoxNumberOfFloors
            // 
            this.textBoxNumberOfFloors.Location = new System.Drawing.Point(182, 153);
            this.textBoxNumberOfFloors.Name = "textBoxNumberOfFloors";
            this.textBoxNumberOfFloors.Size = new System.Drawing.Size(125, 27);
            this.textBoxNumberOfFloors.TabIndex = 5;
            // 
            // labelNumberOfFloors
            // 
            this.labelNumberOfFloors.AutoSize = true;
            this.labelNumberOfFloors.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNumberOfFloors.Location = new System.Drawing.Point(28, 152);
            this.labelNumberOfFloors.Name = "labelNumberOfFloors";
            this.labelNumberOfFloors.Size = new System.Drawing.Size(108, 28);
            this.labelNumberOfFloors.TabIndex = 4;
            this.labelNumberOfFloors.Text = "Этажность";
            // 
            // textBoxSquare
            // 
            this.textBoxSquare.Location = new System.Drawing.Point(182, 202);
            this.textBoxSquare.Name = "textBoxSquare";
            this.textBoxSquare.Size = new System.Drawing.Size(125, 27);
            this.textBoxSquare.TabIndex = 7;
            // 
            // labelSquare
            // 
            this.labelSquare.AutoSize = true;
            this.labelSquare.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSquare.Location = new System.Drawing.Point(28, 201);
            this.labelSquare.Name = "labelSquare";
            this.labelSquare.Size = new System.Drawing.Size(96, 28);
            this.labelSquare.TabIndex = 6;
            this.labelSquare.Text = "Площадь";
            // 
            // textBoxVolume
            // 
            this.textBoxVolume.Location = new System.Drawing.Point(182, 254);
            this.textBoxVolume.Name = "textBoxVolume";
            this.textBoxVolume.Size = new System.Drawing.Size(125, 27);
            this.textBoxVolume.TabIndex = 9;
            // 
            // labelVolume
            // 
            this.labelVolume.AutoSize = true;
            this.labelVolume.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelVolume.Location = new System.Drawing.Point(28, 250);
            this.labelVolume.Name = "labelVolume";
            this.labelVolume.Size = new System.Drawing.Size(75, 28);
            this.labelVolume.TabIndex = 8;
            this.labelVolume.Text = "Объем";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(28, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 38);
            this.label1.TabIndex = 10;
            this.label1.Text = "Жилой дом";
            // 
            // buttonAddHouse
            // 
            this.buttonAddHouse.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddHouse.Location = new System.Drawing.Point(28, 309);
            this.buttonAddHouse.Name = "buttonAddHouse";
            this.buttonAddHouse.Size = new System.Drawing.Size(140, 52);
            this.buttonAddHouse.TabIndex = 11;
            this.buttonAddHouse.Text = "Добавить";
            this.buttonAddHouse.UseVisualStyleBackColor = true;
            this.buttonAddHouse.Click += new System.EventHandler(this.buttonAddTruck_Click);
            // 
            // House
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(365, 373);
            this.Controls.Add(this.buttonAddHouse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxVolume);
            this.Controls.Add(this.labelVolume);
            this.Controls.Add(this.textBoxSquare);
            this.Controls.Add(this.labelSquare);
            this.Controls.Add(this.textBoxNumberOfFloors);
            this.Controls.Add(this.labelNumberOfFloors);
            this.Controls.Add(this.textBoxYearOfConstruction);
            this.Controls.Add(this.labelYearOfConstruction);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.labelAddress);
            this.Name = "House";
            this.Text = "House";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelAddress;
        private TextBox textBoxAddress;
        private TextBox textBoxYearOfConstruction;
        private Label labelYearOfConstruction;
        private TextBox textBoxNumberOfFloors;
        private Label labelNumberOfFloors;
        private TextBox textBoxSquare;
        private Label labelSquare;
        private TextBox textBoxVolume;
        private Label labelVolume;
        private Label label1;
        private Button buttonAddHouse;
    }
}