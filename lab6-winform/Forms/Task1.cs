using lab6_winform.Classes;
namespace lab6_winform
{
    public partial class Task1 : Form
    {
        List<Build> builds = new();
        List<Build> addBuilds;
        public Task1()
        {
            InitializeComponent();

            Build b1 = new("Пять столиц", "Загоровского 1");
            Build b2 = new("Московский проспект", "Московский проспект 129/1");
            Build b3 = new("Галерея Чижова", "Кольцовская 35");
            addBuilds = new(){ b1, b2, b3 };

            listViewTask1.View = View.Details;
            listViewTask1.Columns.Clear();
            listViewTask1.Columns.Add("ID", 30);
            listViewTask1.Columns.Add("Название", 150);
            listViewTask1.Columns.Add("Адрес",150);
            listViewTask1.FullRowSelect = true;

            ReloadCheckedList();
        }
        private void ReloadCheckedList()
        {
            checkedListBoxTask1.Items.Clear();
            foreach (Build build in addBuilds)
                checkedListBoxTask1.Items.Add(build.ToString());
        }
        private void ReloadListView()
        {
            listViewTask1.Items.Clear();
            for(int i = 0; i < builds.Count; i++)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(i + 1));
                ListViewItem.ListViewSubItem title = new(item, builds[i].Title);
                ListViewItem.ListViewSubItem address = new(item, builds[i].Address);
                item.SubItems.Add(title);
                item.SubItems.Add(address);
                listViewTask1.Items.Add(item);
            }
        }

        private void buttonAddTask1_Click(object sender, EventArgs e)
        {
            if (checkedListBoxTask1.CheckedItems.Count == 0) return;
            for (int i = 0; i < checkedListBoxTask1.CheckedItems.Count; i++)
                for (int j = 0; j < addBuilds.Count; j++)
                    if (checkedListBoxTask1.CheckedItems[i].ToString() == addBuilds[j].ToString())
                    {
                        builds.Add(addBuilds[j]);
                        addBuilds.RemoveAt(j);
                    }
            ReloadCheckedList();
            ReloadListView();
        }

        private void buttonInsertTask1_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkedListBoxTask1.CheckedItems.Count == 0) throw new Exception("Выберите дом!");
                for (int i = 0; i < checkedListBoxTask1.CheckedItems.Count; i++)
                    for (int j = 0; j < addBuilds.Count; j++)
                        if (checkedListBoxTask1.CheckedItems[i].ToString() == addBuilds[j].ToString())
                        {
                            int index = Convert.ToInt32(textBoxTask1.Text);
                            textBoxTask1.Text = "";
                            if (index < builds.Count || index < 0) throw new Exception("Неверный индекс!");
                            builds.Insert(index, addBuilds[j]);
                            addBuilds.RemoveAt(j);
                        }
                ReloadCheckedList();
                ReloadListView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSortTask1_Click(object sender, EventArgs e)
        {
            builds.Sort();
            ReloadListView();
        }

        private void buttonRemoveTask1_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(listViewTask1.FocusedItem.SubItems[0].Text) - 1;
            builds.RemoveAt(index);
            ReloadListView();
        }

        private void buttonClearTask1_Click(object sender, EventArgs e)
        {
            builds.Clear();
            ReloadListView();
        }
    }
}