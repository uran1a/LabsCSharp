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
            labelDirectorCompany.Text = company.director.PrintFIO();
            labelAccountentCompany.Text = company.accountant.PrintFIO();
            labelDGuardCompany.Text = company.guard.PrintFIO();
            //
        }
    }
}
