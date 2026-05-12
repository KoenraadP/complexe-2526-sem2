using Connect4.Entities;
using System;
using System.Windows.Forms;

namespace Connect4.App
{
    public partial class FrmConnect4 : Form
    {
        public FrmConnect4()
        {
            InitializeComponent();
        }

        // Load wordt uitgevoerd bij opstarten programma
        private void FrmConnect4_Load(object sender, EventArgs e)
        {
            // token aanmaken
            Token t = new Token();
            // token (eigenlijk een panel dus) toevoegen aan form
            Controls.Add(t);
        }
    }
}
