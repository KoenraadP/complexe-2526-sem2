using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flags
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // eerste element uit combobox al actief plaatsen
            cbxLanguage.SelectedIndex = 0;
        }

        private void CbxLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxLanguage.SelectedIndex == 0)
            {
                lblGreeting.Text = "Goedemorgen";
            }

            //if (cbxLanguage.SelectedItem.ToString() == "English")
            if (cbxLanguage.SelectedIndex == 1)
            {
                lblGreeting.Text = "Good morning!";
            }

            if (cbxLanguage.SelectedIndex == 2)
            {
                lblGreeting.Text = "Bonjour!";
            }

            if (cbxLanguage.SelectedIndex == 3)
            {
                lblGreeting.Text = "Guten Morgen!";
            }

            //switch (cbxLanguage.SelectedIndex)
            //{
            //    case 0:
            //        lblGreeting.Text = "Goedemorgen!";
            //        break;
            //    case 1:
            //        lblGreeting.Text = "Good morning!";
            //        break;
            //}
        }
    }
}
