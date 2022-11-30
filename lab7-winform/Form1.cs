namespace lab7_winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSwapTask3_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBoxNum1.Text);
            int num2 = Convert.ToInt32(textBoxNum2.Text);
            Swap(ref num1, ref num2);
            textBoxNum1.Text = num1.ToString();
            textBoxNum2.Text = num2.ToString();

            void Swap (ref int num1, ref int num2)
            {
                int temp = num1;
                num1 = num2;
                num2 = temp;
            }
        }

        private void buttonCalculatePerimeter_Click(object sender, EventArgs e)
        {
            double sideA = FindSideByCoordinates(Convert.ToInt32(textBoxX1.Text), Convert.ToInt32(textBoxY1.Text), Convert.ToInt32(textBoxX2.Text), Convert.ToInt32(textBoxY2.Text));
            double sideB = FindSideByCoordinates(Convert.ToInt32(textBoxX2.Text), Convert.ToInt32(textBoxY2.Text), Convert.ToInt32(textBoxX3.Text), Convert.ToInt32(textBoxY3.Text));
            double sideC = FindSideByCoordinates(Convert.ToInt32(textBoxX3.Text), Convert.ToInt32(textBoxY3.Text), Convert.ToInt32(textBoxX1.Text), Convert.ToInt32(textBoxY1.Text));
            textBoxPerimeterTask4.Text = Convert.ToString(sideA + sideB + sideC);
            
            double FindSideByCoordinates(int x1, int y1, int x2, int y2)
            {
                return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
            }
        }
    }
}