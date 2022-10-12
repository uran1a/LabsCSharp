using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4_winform.Add
{
    public partial class House : Form
    {
        private Dictionary<string, string> house;
        public Dictionary<string, string> getHouse() => house;
        public House()
        {
            InitializeComponent();
            house = new Dictionary<string, string>();
        }
        private void buttonAddTruck_Click(object sender, EventArgs e)
        {
            house.Add("Тип", "Жилой дом");
            house.Add(labelAddress.Text, textBoxAddress.Text);
            house.Add(labelYearOfConstruction.Text, textBoxYearOfConstruction.Text);
            house.Add(labelNumberOfFloors.Text, textBoxNumberOfFloors.Text);
            house.Add(labelSquare.Text, textBoxSquare.Text);
            house.Add(labelVolume.Text, textBoxVolume.Text);
            this.Close();
        }
    }
}
