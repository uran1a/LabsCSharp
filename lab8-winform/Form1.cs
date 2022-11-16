namespace lab8_winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Console.WriteLine(System.IO.Directory.GetCurrentDirectory());
            var docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string path = @"C:\Users\voron\source\repos\LabsCSharp\lab8-winform";

            Console.WriteLine(docPath);
            var dirName = $@"{path}\test";

            DirectoryInfo di = Directory.CreateDirectory(dirName);
            Console.WriteLine($"Full name: {di.FullName}, Name: {di.Name}, Parent: {di.Parent}");

            if (Directory.Exists(dirName))
                Console.WriteLine("Directory exists");
            else
                Console.WriteLine("Directory does not exist");
            //string path = @"C:\Users\voron\source\repos\LabsCSharp\lab8-winform";
            //System.IO.Directory.CreateDirectory(path);
        }
    }
}