namespace lab5_winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonComputationTask2_Click(object sender, EventArgs e)
        {
            try{
                if (textBoxTask2.Text == "") throw new Exception("¬ведите текст!");
                String[] words = textBoxTask2.Text.Split(" ");
                String line = "";
                for(int i = 0; i < words.Length; i++)
                {
                    words[i] = words[i].TrimStart(words[i][0]);
                    words[i] = words[i].TrimEnd(words[i][words[i].Length-1]);
                    line += words[i] + " ";
                }

                labelResultTask2.Text = line;
            } 
            catch ( Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}