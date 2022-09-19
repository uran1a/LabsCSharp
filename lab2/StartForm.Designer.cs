namespace lab2
{
    partial class StartForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.NumberLab = new System.Windows.Forms.Label();
            this.ButtonTransitionToTask1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NumberLab
            // 
            this.NumberLab.AutoSize = true;
            this.NumberLab.BackColor = System.Drawing.Color.White;
            this.NumberLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F);
            this.NumberLab.Location = new System.Drawing.Point(34, 7);
            this.NumberLab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NumberLab.Name = "NumberLab";
            this.NumberLab.Size = new System.Drawing.Size(220, 29);
            this.NumberLab.TabIndex = 0;
            this.NumberLab.Text = "Лабораторная №1";
            // 
            // ButtonTransitionToTask1
            // 
            this.ButtonTransitionToTask1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.ButtonTransitionToTask1.Location = new System.Drawing.Point(9, 148);
            this.ButtonTransitionToTask1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonTransitionToTask1.Name = "ButtonTransitionToTask1";
            this.ButtonTransitionToTask1.Size = new System.Drawing.Size(138, 40);
            this.ButtonTransitionToTask1.TabIndex = 1;
            this.ButtonTransitionToTask1.Text = "Задание №1";
            this.ButtonTransitionToTask1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.button2.Location = new System.Drawing.Point(151, 148);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 40);
            this.button2.TabIndex = 2;
            this.button2.Text = "Задание №2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(299, 204);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ButtonTransitionToTask1);
            this.Controls.Add(this.NumberLab);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "StartForm";
            this.Text = "Стартовая панель";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NumberLab;
        private System.Windows.Forms.Button ButtonTransitionToTask1;
        private System.Windows.Forms.Button button2;
    }
}

