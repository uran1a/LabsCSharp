using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;

namespace lab10_winform
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
            FillComboBox(comboBoxSex, ReadFile(@"C:\Users\voron\source\repos\LabsCSharp\lab10-winform\List\Sex.txt"));
            FillComboBox(comboBoxPost, ReadFile(@"C:\Users\voron\source\repos\LabsCSharp\lab10-winform\List\Post.txt"));
            FillComboBox(comboBoxFaculty, ReadFile(@"C:\Users\voron\source\repos\LabsCSharp\lab10-winform\List\Faculty.txt"));
        }
        private void FillComboBox(ComboBox comboBox, List<string> list)
        {
            foreach(var item in list)
                comboBox.Items.Add(item);
        }
        private List<string> ReadFile (String path)
        {
            List<string> content = new List<string>();
            using(StreamReader reader = new StreamReader(path))
            {
                while(!reader.EndOfStream)
                    content.Add(reader.ReadLine());
            }
            return content;
        }
        private string CheckingFileName()
        {
            DirectoryInfo di = new DirectoryInfo(@"C:\Users\voron\source\repos\LabsCSharp\lab10-winform\Account\");
            bool isSuitableName = false;
            string fileName = String.Empty;
            Random rand = new Random();
            do
            {
                fileName = "person" + rand.Next(0, 1000) + ".json";
                foreach (var file in di.GetFiles())
                {
                    if (fileName == file.Name)
                        isSuitableName = true;
                }
            }
            while (isSuitableName);
            return di.FullName + fileName;
        }
        private async void buttonSignUp_Click(object sender, EventArgs e)
        {
            Person p = new Person(textBoxFIO.Text, comboBoxSex.SelectedItem.ToString(), comboBoxPost.SelectedItem.ToString(), comboBoxFaculty.SelectedItem.ToString(), textBoxLogin.Text, textBoxPassword.Text);
            using (Stream SourceStream = File.Open(CheckingFileName(), FileMode.Create))
            {
                await JsonSerializer.SerializeAsync<Person>(SourceStream, p);
                MessageBox.Show("Вы успешно зарегистровались!");
            }
            this.Close();
        }
    }
}
