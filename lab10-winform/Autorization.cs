using System.Text.Json;
namespace lab10_winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private async void buttonSignIn_Click(object sender, EventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo(@"C:\Users\voron\source\repos\LabsCSharp\lab10-winform\Account\");
            foreach (var file in di.GetFiles())
            {
                using (Stream SourceStream = File.Open(file.FullName, FileMode.Open))
                {
                    var personJson = await JsonSerializer.DeserializeAsync<Person>(SourceStream);
                    if (textBoxLogin.Text == personJson.Login && textBoxPassword.Text == personJson.Password)
                        MessageBox.Show("Вы успешно авторизовались!");
                }
            }
            
        }

        private void labelSignUp_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            reg.ShowDialog();
        }
    }
}