using Connect4.Bll;
using Connect4.Entities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Connect4.App
{
    public partial class FrmConnect4 : Form
    {
        // properties form
        public Game Game { get; set; }  

        public FrmConnect4()
        {
            InitializeComponent();
        }

        // Load wordt uitgevoerd bij opstarten programma
        private void FrmConnect4_Load(object sender, EventArgs e)
        {
            StartGame();
            Console.WriteLine(Game.Grid[0, 0]); // grid testen
        }

        // methode om Game te starten
        private void StartGame()
        {
            // nieuw Game initialiseren
            // start automatisch met alle waarden 
            // uit constructor van Game class
            Game = new Game(this); // this --> deze form (FrmConnect4)
            Game.PlaceTokens();
        }
    }
}
