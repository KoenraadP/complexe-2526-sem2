using Flags.Properties;
using System;
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
                // picturebox invullen met correcte afbeelding
                pbxFlag.Image = Resources.Flag_NL;
                // je kan ook werken met ImageLocation 
                //pbxFlag.ImageLocation = "https://t4.ftcdn.net/jpg/01/16/24/15/360_F_116241515_2Gq7EBxGr73TbSqrFb2bJnAYhI7SJ3dB.jpg";
            }

            //if (cbxLanguage.SelectedItem.ToString() == "English")
            if (cbxLanguage.SelectedIndex == 1)
            {
                lblGreeting.Text = "Good morning!";
                pbxFlag.Image = Resources.Flag_UK;
            }

            if (cbxLanguage.SelectedIndex == 2)
            {
                lblGreeting.Text = "Bonjour!";
                pbxFlag.Image = Resources.Flag_FR;
            }

            if (cbxLanguage.SelectedIndex == 3)
            {
                lblGreeting.Text = "Guten Morgen!";
                pbxFlag.Image = Resources.Flag_DE;
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
