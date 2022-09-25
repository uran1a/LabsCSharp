using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lab1;
namespace lab2_winForm
{
    public partial class ChangeEmployee<T> : Form where T : Person
    {
        public T returnEmployee { get => this.currentDirector; }
        List<T> list;
        T currentDirector;
        public ChangeEmployee(ref List<T> list, ref T currentDirector)
        {
            InitializeComponent();

            this.list = list;
            Console.WriteLine(currentDirector);
            this.currentDirector = currentDirector;
            Console.WriteLine(this.currentDirector);
            listViewChangeEmployeeCompany.View = View.Details;
            listViewChangeEmployeeCompany.Columns.Clear();
            listViewChangeEmployeeCompany.Columns.Add("#", 21, HorizontalAlignment.Center);
            listViewChangeEmployeeCompany.Columns.Add("ФИО", 180, HorizontalAlignment.Center);
            listViewChangeEmployeeCompany.FullRowSelect = true;
            for (int i = 0; i < list.Count; i++)
            {
                ListViewItem newItem = new ListViewItem(Convert.ToString(i + 1));
                ListViewItem.ListViewSubItem FIO = new ListViewItem.ListViewSubItem(newItem, list[i].PrintFIO());
                newItem.SubItems.Add(FIO);
                listViewChangeEmployeeCompany.Items.AddRange(new ListViewItem[] { newItem });
            }
        }
        private void buttonChangeEmployeeCompany_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(listViewChangeEmployeeCompany.FocusedItem.SubItems[0].Text) - 1;
            T newDirector = list[index];
            list.RemoveAt(index);
            list.Add(this.currentDirector);
            this.currentDirector = newDirector;
            this.Close();
        }
    }
}
