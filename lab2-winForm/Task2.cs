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
    public partial class Task2 : Form
    {
        //поля
        Company company;
        List<Director> possibleDirectors;
        List<Accountant> possibleAccountants;
        List<Guard> possibleGuards;
        public Task2()
        {
            InitializeComponent();
            Director currentDirector = new Director("Тимофей", "Савельев", "Даниилович", 19, 2.0, 25000, 2.0, 0);
            //labelTitleCompany.Text = currentDirector.ToString();
            Accountant currentAccountant = new Accountant("Екатерина", "Тарасова", "Кирилловна", 25, 5.1, 40000, 3.0);
            Guard currentGuard = new Guard("Степан", "Игнатьев", "Юрьевич", 49, 15.0, 15000, "Орёл");
            company = new Company(currentDirector, currentAccountant, currentGuard);
            Employee e1 = new Employee("Лев", "Зорин", "Павлович", 35, 3.0, 35000, "Аналитик", "СБЕР");
            Employee e2 = new Employee("Марина", "Макарова", "Константиновна", 35, 3.0, 35000, "Юридический", "СБЕР");
            company.AddEmployee(e1);
            company.AddEmployee(e2);

            Director d1 = new Director("Владимир", "Дубровин", "Даниилович", 31, 2.0, 25000, 14.0, 3);
            Director d2 = new Director("Грибова", "Алиса", "Кирилловна", 23, 2.0, 25000, 4.0, 2);
            Director d3 = new Director("Богдан", "Куликов", "Максимович", 43, 2.0, 25000, 20.0, 4);
            possibleDirectors = new List<Director>() { d1, d2, d3 };

            listViewEmployees.View = View.Details;
            listViewEmployees.Columns.Clear();
            listViewEmployees.Columns.Add("#", 21, HorizontalAlignment.Center);
            listViewEmployees.Columns.Add("ФИО", 180, HorizontalAlignment.Center);
            listViewEmployees.Columns.Add("Отдел", 175, HorizontalAlignment.Center);

            listViewEmployees.FullRowSelect = true;

            for (int i = 0; i < company.employees.Count; i++)
            {
                ListViewItem newItem = new ListViewItem(Convert.ToString(i+1));
                ListViewItem.ListViewSubItem Login = new ListViewItem.ListViewSubItem(newItem, company.employees[i].PrintFIO());
                ListViewItem.ListViewSubItem Password = new ListViewItem.ListViewSubItem(newItem, company.employees[i].department);
                newItem.SubItems.Add(Login);
                newItem.SubItems.Add(Password);
                listViewEmployees.Items.AddRange(new ListViewItem[] { newItem });
            }
            //
        }
        private void buttonChangeDirectorCompany_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            ChangeEmployeeCompany form = new ChangeEmployeeCompany(ref possibleDirectors, ref company.director);
            form.ShowDialog();
            company.director = form.DirectorNew;
        }

        private void Task2_Activated(object sender, EventArgs e)
        {
            Console.WriteLine("Форма активна!");
            Console.WriteLine($"Директор {company.director.PrintFIO()}");
            labelDirectorCompany.Text = company.director.PrintFIO();
            labelAccountentCompany.Text = company.accountant.PrintFIO();
            labelDGuardCompany.Text = company.guard.PrintFIO();
        }
    }
}
