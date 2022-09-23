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
            this.panelResultSubtask1.Visible = false;
            this.panelResultSubtask2.Visible = false;
            this.panelResultSubtask3.Visible = false;
            this.labelResultTime.Visible = false;

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
                this.panelResultSubtask1.Visible = true;
            }

            void FindResultVariables(double x, double y, double z, out double a, out double b)
            {
                a = (Math.Abs(5 - 2 * Math.E) / (1 + Math.Pow(x, 2) * (y - Math.Tan(z))));
                b = Math.Abs(y - 4) + (Math.Pow(y - x, 2) / 6) + (Math.Pow(x - y, 2) / 7);
            }
        }

        private void buttonCalculation_Click(object sender, EventArgs e)
        {
            SplitTextBoxString(textBoxX1Y1, out int[] arrСoordinatesA);
            SplitTextBoxString(textBoxX2Y2, out int[] arrСoordinatesB);
            SplitTextBoxString(textBoxX3Y3, out int[] arrСoordinatesC);
            LengthSide(arrСoordinatesA, arrСoordinatesB, out double ab);
            LengthSide(arrСoordinatesB, arrСoordinatesC, out double bc);
            LengthSide(arrСoordinatesA, arrСoordinatesC, out double ac);
            
            double Perimeter = (ab + bc + ac) / 2;
            double Square = Math.Sqrt(Perimeter * (Perimeter - ab) * (Perimeter - bc) * (Perimeter - ac));
            double Radius = (ab * bc * ac) / (4 * Square);

            labelResultRadius.Text = $"R = {Radius}";
            this.panelResultSubtask2.Visible = true;

            void SplitTextBoxString(TextBox textBox, out int[] arr)
            {
                const int SIZE = 2;
                arr = new int[SIZE];
                String[] arrStr = textBox.Text.ToString().Split(',');
                for (int i = 0; i < SIZE; i++)
                    arr[i] = Convert.ToInt32(arrStr[i].Trim());
            }
            void LengthSide(int[] coordinatesA, int[] coordinatesB, out double ab)
            {
                ab = Math.Sqrt(
                Math.Pow(coordinatesB[0] - coordinatesA[0], 2)
                +
                Math.Pow(coordinatesB[1] - coordinatesA[1], 2));
            }
        }

        private void buttonСalculation3_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBoxNumber1.Text);
            double b = Convert.ToDouble(textBoxNumber2.Text);
            if (a != b)
            {
                labelResultEquals.Text = $"Сумма введёных чисел: {a + b}\nПроизведение введёных чисел: {Math.Round(a*b, 2)}";
            }
            else labelResultEquals.Text = "Числа равны друг другу!";
            panelResultSubtask3.Visible = true;
        }

        private void buttonResultSubtask4_Click(object sender, EventArgs e)
        {
            double vremya = Convert.ToDouble(textBoxTime.Text);
            if (vremya >= 0 && vremya <= 24)
                labelResultTime.Text = $"Время суток: {vremya}:00";
            else labelResultTime.Text = "Неверное значение!";
            labelResultTime.Visible = true;
        }
    }
}
