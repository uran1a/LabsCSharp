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
            listView.Columns.Clear();
            listView.Items.Clear();

            listView.Columns.Add("#", 30, HorizontalAlignment.Center);
            listView.Columns.Add("ddd ", 950, HorizontalAlignment.Left);
            for (int i = 0; i < listObjects.Count; i++)
            {
                string lineObject = "";
                ListViewItem newItem = new ListViewItem(Convert.ToString(i + 1));
                foreach (KeyValuePair<string, string> pair in listObjects[i])
                {
                    lineObject += (pair.Key + ": " + pair.Value);
                }
                ListViewItem.ListViewSubItem Value = new ListViewItem.ListViewSubItem(newItem, lineObject);
                newItem.SubItems.Add(Value);
                listView.Items.AddRange(new ListViewItem[] { newItem });
            }
        }
        private void buttonAddCargoPlane_Click(object sender, EventArgs e)
        {
            CargoPlane pl = new CargoPlane();
            pl.ShowDialog();
            listObjects.Add(pl.getCargoPlane());
            reloadListView();
        }
        private void buttonAddHouse_Click(object sender, EventArgs e)
        {
            House hs = new House();
            hs.ShowDialog();
            listObjects.Add(hs.getHouse());
            reloadListView();
        }
    }
}