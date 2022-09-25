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
    public partial class AddEmployee : Form
    {
        private List<Employee> employees;
        private List<Employee> possibleEmployees;
        public AddEmployee(ref List<Employee> employees, ref List<Employee> possibleEmployees)
        {
            this.employees = employees;
            this.possibleEmployees = possibleEmployees;
            InitializeComponent();
            checkedListBoxEmployees.Items.Clear();
            foreach (Employee employee in possibleEmployees)
                checkedListBoxEmployees.Items.Add(employee.PrintFIO());
        }

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {   
            if(checkedListBoxEmployees.CheckedItems.Count > 0)
            {
                for (int i = 0; i < checkedListBoxEmployees.CheckedItems.Count; i++)
                    for(int j = 0; j < possibleEmployees.Count; j++)
                        if(checkedListBoxEmployees.CheckedItems[i].ToString() == possibleEmployees[j].PrintFIO())
                        {
                            employees.Add(possibleEmployees[j]);
                            possibleEmployees.RemoveAt(j);
                        }
            }
            this.Close();
        }
    }

}
