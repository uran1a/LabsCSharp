namespace lab2_winForm
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void buttonTask2_Click(object sender, EventArgs e)
        {
            Task2 task = new Task2();
            task.Show();
        }
    }
}