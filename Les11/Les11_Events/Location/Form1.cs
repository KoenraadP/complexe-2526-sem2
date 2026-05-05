using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Location
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // deze event methode wordt uitgevoerd wanneer je ergens
        // binnen het form met de muis klikt
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            // testen of event werkt
            //lblX.Text = "Je hebt geklikt!";

            // tonen in de labels 'waar' in het form ik geklikt heb
            lblX.Text = e.X.ToString();
            lblY.Text = e.Y.ToString();

            // panel plaatsen waar ik klik
            // de linker bovenhoek van het element wordt op het 'point' geplaatst
            int mouseX = e.X;
            int mouseY = e.Y;
            //pnlLocation.Location = new Point(mouseX, mouseY);

            // panel bovenaan links zetten
            //pnlLocation.Location = new Point(0, 0); 

            // panel onderaan rechts zetten
            // clientsize --> het grijs stuk van de form waar we effectief in werken
            // zonder de 'titelbalk' meegerekend
            int formWidth = ClientSize.Width;
            int formHeight = ClientSize.Height;
            int panelWidth = pnlLocation.Width; //106
            int panelHeight = pnlLocation.Height; //87   
            pnlLocation.Location = new Point(formWidth - panelWidth, 
                                            formHeight - panelHeight);
        }
    }
}
