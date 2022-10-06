namespace lab3_winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            labelResult5.Visible = false;
            labelResult6.Visible = false;
            labelResult8.Visible = false;
        }

        private void buttonCalculation6_Click(object sender, EventArgs e)
        {
            static double func(int x)
            {
                return (2 * Math.Pow(x, 2)) + (108 / Math.Pow(x, 2)) - 59;
            }
            try
            {
                int startSegment = Convert.ToInt32(numericUpDown1.Value);
                int endSegment = Convert.ToInt32(numericUpDown2.Value);
                if (startSegment >= endSegment) throw new Exception("Не верный отрезок!");
                double sum = 0;
                for (int i = startSegment; i <= endSegment; i++)
                    sum += func(i);
                labelResult6.Text = Convert.ToString(Math.Round(sum,2));
                labelResult6.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: "+ex.Message);
            }
        }

        private void buttonResult8_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(numericUpDown4.Value);
            int sum = 0;
            for (int i = 1; i <= n; i++)
                sum += Convert.ToInt32(Math.Pow(i, n - i + 1));
            labelResult8.Text = Convert.ToString(sum);
            labelResult8.Visible = true;
        }

        private void buttonResult5_Click(object sender, EventArgs e)
        {
            double eps = Convert.ToDouble(textBoxEps.Text);
            double sum = 0, s = 999999;
            for (int i = 1; s > eps; i++)
            {
                s = 1 / Math.Sqrt(Factorial(i));
                sum += s;
            }
            sum = sum - s;
            labelResult5.Text = Convert.ToString(Math.Round(sum,2));
            labelResult5.Visible = true;
            int Factorial(int m)
            {
                if (m == 1) return 1;
                return m * Factorial(m - 1);
            }
        }
    }
}