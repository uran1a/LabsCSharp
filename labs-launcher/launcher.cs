using System.Diagnostics;
using System.Text.RegularExpressions;
namespace launcher
{
    public partial class launcher : Form
    {
        struct Laboratory
        {
            public string titleLab { get; set; }
            public List<string> taksLab { get; set; }
        }
        List<Laboratory> laboratoryList;
        public launcher()
        {
            InitializeComponent();
            laboratoryList = new List<Laboratory>();
            string? dirName = Application.StartupPath;
            string? dir = @"N:\code\2021\Study\c#\Labs\lab1";
            Console.WriteLine(dirName);

            var regexLab = new Regex(@"lab\d+-task\d+|-\d");
            string[] folders = Directory.GetDirectories(dir, $"lab*");
            List<string> labs = new List<string>();
            foreach (string folder in folders)
            {
                Laboratory laboratory = new Laboratory();
                laboratory.taksLab = new List<string>();
                string[] titleNode = folder.Split('\\');
                string titleFolder = titleNode[titleNode.Length - 1];
                if (regexLab.IsMatch(titleFolder))
                {  
                    laboratory.titleLab = titleFolder.Split('-')[0];
                    bool check = false;
                    foreach (Laboratory lab in laboratoryList)
                        if (lab.titleLab == laboratory.titleLab) check = true;
                    if (!check)
                        laboratoryList.Add(laboratory);
                }

            }
            treeViewLabs.Nodes.Clear();
            foreach (Laboratory lab in laboratoryList)
            {
                string[] files = Directory.GetFiles(dir, $"{lab.titleLab}*.exe", SearchOption.AllDirectories);
                TreeNode newTreeNode = new TreeNode(lab.titleLab);
                foreach (string file in files)
                {
                    lab.taksLab.Add(file);
                    string[] titleNode = file.Split(@"\");
                    TreeNode newTreeSubNode = new TreeNode(titleNode[titleNode.Length - 1]);
                    newTreeNode.Nodes.Add(newTreeSubNode);
                }
                treeViewLabs.Nodes.AddRange(new TreeNode[] { newTreeNode });
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            /*
            Console.WriteLine(treeViewLabs.SelectedNode.Index);
            Console.WriteLine();
           foreach(Laboratory lab in laboratoryList)
            {
                foreach(string task in lab.taksLab)
                Console.WriteLine(task);
            }
            */
            try
            {
                if (treeViewLabs.SelectedNode.Nodes.Count != 0) throw new Exception();
                //Process.Start(@"N:\code\2021\Study\c#\Labs\lab1\lab2-winForm\bin\Debug\net6.0-windows\lab1-console.exe");
                Process.Start(laboratoryList[treeViewLabs.SelectedNode.Parent.Index].taksLab[treeViewLabs.SelectedNode.Index]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}