using System.IO;
using System.Text;
namespace lab8_winform
{
    public partial class Form1 : Form
    {
        private DirectoryInfo dir;
        private string fileName;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCreateFolderTask1_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\voron\source\repos\LabsCSharp\lab8-winform";
            var dirName = $@"{path}\{textBoxTitleFolder.Text}";
            dir = Directory.CreateDirectory(dirName);
            if (Directory.Exists(dirName))
                MessageBox.Show("Папка создана");
            Console.Write(dir.FullName);
        }

        private void buttonCreateFileTask1_Click(object sender, EventArgs e)
        {

            if(dir is null)
            {
                MessageBox.Show("Сначала надо создать папку");
                return;
            }
            fileName = $@"{dir.FullName}\{textBoxTitleFile.Text}.txt";
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                int[] arrayRandomNumbers = FillArrayRandomNumbers(10);
                string lineRandomNumbers = String.Join(" ", arrayRandomNumbers);
                writer.Write(lineRandomNumbers);
                MessageBox.Show($"Файл создан.\nЗаполнен: {lineRandomNumbers}");
            }
            
            int[] FillArrayRandomNumbers(int size)
            {
                Random rnd = new Random();
                int[] arr = new int[size];
                for (int i = 0; i < arr.Length; i++)
                    arr[i] = rnd.Next(0, 100);
                return arr;
            }    
        }
        private void buttonFindSum_Click(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                string[] line = reader.ReadLine().Split(" ");
                int[] arrayNumbers = Array.ConvertAll(line, l => Convert.ToInt32(l));
                int sum = 1;
                foreach(int item in arrayNumbers)
                    if(item % 2 == 0) sum *= item;
                textBoxResultTask1.Text = Convert.ToString(sum);
            }
        }
    }
}