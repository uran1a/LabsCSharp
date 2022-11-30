namespace lab9_winform
{
    public partial class Form1 : Form
    {
        private string fullNameFirstFile;
        private string pathCurrentDiractory = @"C:\Users\voron\source\repos\LabsCSharp\lab9-winform";
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOpenFIleTask3_Click(object sender, EventArgs e)
        {
            string fileName = pathCurrentDiractory+@"\states.dat";
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = pathCurrentDiractory;
                openFileDialog.Filter = "BinText files (*.dat*)|*.dat*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    fullNameFirstFile = openFileDialog.FileName;
                    textBoxOpenFile.Text = fullNameFirstFile.Split("\\").Last<string>();
                }
            }
        }

        private void buttonCopyFile_Click(object sender, EventArgs e)
        {
            if(textBoxCopyFIle.Text == "") { MessageBox.Show("��������� ��� �����"); return; }
            string fullNameSecondFile = pathCurrentDiractory+textBoxCopyFIle.Text+".dat";
            try
            {
                File.Copy(fullNameFirstFile, fullNameSecondFile);
            }
            catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonOpenFIleTask4_Click(object sender, EventArgs e)
        {
            
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = pathCurrentDiractory;
                openFileDialog.Filter = "BinText files (*.dat*)|*.dat*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fullName = openFileDialog.FileName;
                    string content = "";
                    using (BinaryReader reader = new BinaryReader(File.Open(fullName, FileMode.Open)))
                    {
                        content = reader.ReadString();
                    }
                        textBoxFileInformation.Text =
                            "���: " + fullName.Split("\\").Last<string>() + Environment.NewLine + 
                            "�������: " + content + Environment.NewLine +
                            "���� � ����� �������� ��������� �����: " + File.GetCreationTimeUtc(fullName) + Environment.NewLine +
                            "���� � ����� ���������� ������� � ��������� �����: " + File.GetLastAccessTimeUtc(fullName) + Environment.NewLine +
                            "���� � ����� ��������� �������� ������ � �������� ����: " + File.GetLastWriteTimeUtc(fullName) + Environment.NewLine
                        ;
                }
            }
        }
    }
}