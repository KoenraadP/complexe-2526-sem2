using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovePicture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnDown_Click(object sender, EventArgs e)
        {
            Console.WriteLine(pbxImage.Top.ToString());
            // afstand tot aan de bovenkant (top) van mijn formulier vergroten
            pbxImage.Top += 10;
        }

        private void BtnUp_Click(object sender, EventArgs e)
        {
            pbxImage.Top -= 10;
            // pbxImage.Bottom += 10; // dit werkt niet
        }

        private void BtnRight_Click(object sender, EventArgs e)
        {
            pbxImage.Left += 10;
        }

        private void BtnLeft_Click(object sender, EventArgs e)
        {
            pbxImage.Left -= 10;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // knoppen uitschakelen om key event te doen werken
            // als je deze toch weer wil gebruiken, zet dan deze code gewoon in comment
            btnDown.Enabled = false;
            btnUp.Enabled = false;
            btnRight.Enabled = false;
            btnLeft.Enabled = false;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // als ik op het pijltje omlaag druk...
            if (e.KeyCode == Keys.Down) pbxImage.Top += 10;
            if (e.KeyCode == Keys.Up) pbxImage.Top -= 10;
            if (e.KeyCode == Keys.Right) pbxImage.Left += 10;
            if (e.KeyCode == Keys.Left) pbxImage.Left -= 10;

            // alternatief met switch voorbeeld
            //switch (e.KeyCode)
            //{
            //    case Keys.Down:
            //        pbxImage.Top += 10;
            //        break;
            //}
        }
    }
}
