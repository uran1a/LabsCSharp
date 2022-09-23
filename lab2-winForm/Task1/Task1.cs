using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2_winForm_Task1
{
    public partial class Task1 : Form
    {
        public Task1()
        {
            InitializeComponent();
            this.panelResult.Visible = false;
        }

        private void buttonСalculation_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(textBoxX.Text.ToString()) && !string.IsNullOrWhiteSpace(textBoxY.Text.ToString()) && !string.IsNullOrWhiteSpace(textBoxZ.Text.ToString()))
            {
                double x = Convert.ToDouble(textBoxX.Text.ToString());
                double y = Convert.ToDouble(textBoxY.Text.ToString());
                double z = Convert.ToDouble(textBoxZ.Text.ToString());

                FindResultVariables(x, y, z, out double a, out double b);
                labelResultA.Text = $"A = {Math.Round(a, 5)}";
                labelResultB.Text = $"B = {Math.Round(b, 5)}";
                this.panelResult.Visible = true;
            }

            void FindResultVariables(double x, double y, double z, out double a, out double b)
            {
                a = (Math.Abs(5 - 2 * Math.E) / (1 + Math.Pow(x, 2) * (y - Math.Tan(z))));
                b = Math.Abs(y - 4) + (Math.Pow(y - x, 2) / 6) + (Math.Pow(x - y, 2) / 7);
            }
        }
    }
}
