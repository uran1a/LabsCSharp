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
    public partial class CargoPlane : Form
    {
        private Dictionary<string, string> cargoPlane;
        public Dictionary<string, string> getCargoPlane() => cargoPlane;
        public CargoPlane()
        {
            InitializeComponent();
            cargoPlane = new Dictionary<string, string>();
        }

        private void buttonAddCargoPlane_Click(object sender, EventArgs e)
        {
            cargoPlane.Add("Тип", "Грузовой самолет");
            cargoPlane.Add(labelModule.Text, textBoxModule.Text);
            cargoPlane.Add(labelCrew.Text, textBoxCrew.Text);
            cargoPlane.Add(labelLenght.Text, textBoxLength.Text);
            cargoPlane.Add(labelMaxWeight.Text, textBoxMaxWeight.Text);
            cargoPlane.Add(labelMaxSpeed.Text, textBoxMaxSpeed.Text);
            cargoPlane.Add(labelLengthWing.Text, textBoxLengthWing.Text);
            this.Close();
        }
    }
}
