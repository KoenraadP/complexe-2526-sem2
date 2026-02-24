using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cars
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // auto's aanmaken
            Car car1 = new Car("Toyota", "Celica", 2025, 250);
            Car car2 = new Car("BMW", "X3", 2020, 280);
            // auto's toevoegen aan combobox
            cbxCars.Items.Add(car1);
            cbxCars.Items.Add(car2);
        }

        private void cbxCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            // huidig geselecteerde auto opslaan
            Car selectedCar = (Car)cbxCars.SelectedItem;
            // jaar in txtYear plaatsen
            txtYear.Text = selectedCar.Year.ToString();
        }
    }
}
