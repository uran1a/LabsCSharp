using lab2_winForm_Task1;
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
            task.ShowDialog();
        }

        private void buttonTask1_Click(object sender, EventArgs e)
        {
            Task1 task = new Task1();
            task.ShowDialog();
        }
    }
}