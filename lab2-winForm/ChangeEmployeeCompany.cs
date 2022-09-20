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
    public partial class ChangeEmployeeCompany : Form
    {
        public Director DirectorNew { get => this.currentDirector;}
        List<Director> list;
        Director currentDirector;
        public ChangeEmployeeCompany(ref List<Director> list,ref Director currentDirector)
        {
            this.list = list;
            Console.WriteLine(currentDirector);
            this.currentDirector = currentDirector;
            Console.WriteLine(this.currentDirector);
            InitializeComponent();
            //вынести в отдельную функцию reload
            listViewChangeEmployeeCompany.View = View.Details;
            listViewChangeEmployeeCompany.Columns.Clear();
            listViewChangeEmployeeCompany.Columns.Add("#", 21, HorizontalAlignment.Center);
            listViewChangeEmployeeCompany.Columns.Add("ФИО", 180, HorizontalAlignment.Center);
            listViewChangeEmployeeCompany.Columns.Add("Опыт руководства (лет)", 175, HorizontalAlignment.Center);
            listViewChangeEmployeeCompany.Columns.Add("Кол-во других компаний", 175, HorizontalAlignment.Center);

            listViewChangeEmployeeCompany.FullRowSelect = true;

            for (int i = 0; i < list.Count; i++)
            {
                ListViewItem newItem = new ListViewItem(Convert.ToString(i + 1));
                ListViewItem.ListViewSubItem FIO = new ListViewItem.ListViewSubItem(newItem, list[i].PrintFIO());
                ListViewItem.ListViewSubItem Experience = new ListViewItem.ListViewSubItem(newItem, Convert.ToString(list[i].experienceInManagent));
                ListViewItem.ListViewSubItem Companies = new ListViewItem.ListViewSubItem(newItem, Convert.ToString(list[i].countOfOtherCompanies));
                newItem.SubItems.Add(FIO);
                newItem.SubItems.Add(Experience);
                newItem.SubItems.Add(Companies);
                listViewChangeEmployeeCompany.Items.AddRange(new ListViewItem[] { newItem });
            }
        }
        private void buttonChangeEmployeeCompany_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(listViewChangeEmployeeCompany.FocusedItem.SubItems[0].Text) - 1;
            Director newDirector = list[index];
            list.RemoveAt(index);
            list.Add(currentDirector);
            currentDirector = newDirector;
        }
    }
}
