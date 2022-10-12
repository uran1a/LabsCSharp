using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace lab4_winform.Add
{
    public partial class Truck : Form
    {
        private Dictionary<string, string> truck;
        public Dictionary<string, string> getTruck() => truck;
        public Truck()
        {
            InitializeComponent();
            truck = new Dictionary<string, string>();
        }
        private void buttonAddTruck_Click(object sender, EventArgs e)
        {
            truck.Add("Тип", "Грузовой автомобиль");
            truck.Add(labelBrand.Text, textBoxBrand.Text);
            truck.Add(labelYear.Text, textBoxYear.Text);
            truck.Add(labelMileage.Text, textBoxMileage.Text);
            truck.Add(labelMaxWeight.Text, textBoxMaxWeight.Text);
            truck.Add(labelCargo.Text, textBoxCargo.Text);
            this.Close();
        }
    }
}
