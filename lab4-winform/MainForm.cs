using lab4_winform.Add;
namespace lab4_winform
{
    public partial class MainForm : Form
    {
        private List<Dictionary<string, string>> listObjects;
        public MainForm()
        {
            InitializeComponent();
            listObjects = new List<Dictionary<string, string>>();

            listView.View = View.Details;
            listView.Columns.Clear();
            listView.FullRowSelect = true;
        }

        private void buttonAddTruck_Click(object sender, EventArgs e)
        {
            Truck tr = new Truck();
            tr.ShowDialog();
            listObjects.Add(tr.getTruck());
            reloadListView();
        }
        private void reloadListView()
        {
            const string TYPE = "“ËÔ";
            listView.Items.Clear();
            for (int i = 0; i < listObjects.Count; i++)
            {
                listView.Columns.Add(TYPE, 50, HorizontalAlignment.Center);
                listView.Columns.Add(listObjects[i].Values.First(), 180, HorizontalAlignment.Center);
                foreach (KeyValuePair<string, string> pair in listObjects[i])
                {
                    if (pair.Key == TYPE) continue;
                    ListViewItem newItem = new ListViewItem(pair.Key);
                    ListViewItem.ListViewSubItem Value = new ListViewItem.ListViewSubItem(newItem, pair.Value);
                    newItem.SubItems.Add(Value);
                    listView.Items.AddRange(new ListViewItem[] { newItem });
                }
            }
            
        }

        private void buttonAddCargoPlane_Click(object sender, EventArgs e)
        {

        }
    }
}