using System.Diagnostics;
namespace launcher
{
    public partial class launcher : Form
    {
        List<string> dirLabs;
        public launcher()
        {
            InitializeComponent();
            string? dirName = Application.StartupPath;
            Console.WriteLine(dirName);
            string[] files = Directory.GetFiles(dirName, "lab*.exe");
            List<string> dirLabs = new List<string>();
            foreach (string file in files)
                dirLabs.Add(file);
            this.dirLabs = dirLabs;
            listViewLabs.View = View.Details;
            listViewLabs.FullRowSelect = true;
            listViewLabs.Columns.Clear();
            listViewLabs.Columns.Add("Название", 180, HorizontalAlignment.Center);
            listViewLabs.Items.Clear();
            foreach(string lab in dirLabs)
            {
                string[] title = lab.Split('\\');
                listViewLabs.Items.AddRange(new ListViewItem[] { new ListViewItem(title[title.Length-1]) });
            }
        }
        private void buttonStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewLabs.SelectedItems.Count == 0) throw new Exception();
                Console.WriteLine();
                Process.Start(dirLabs[listViewLabs.SelectedIndices[0]]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}