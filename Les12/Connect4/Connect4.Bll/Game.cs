using Connect4.Entities;
using System.Drawing;
using System.Windows.Forms;

namespace Connect4.Bll
{
    // alle velden in het speelveld/game
    // zijn ofwel leeg (grijs), rood of geel
    public enum FieldState
    {
        Empty, // eerste is default waarde
        Red,
        Yellow
    }

    public class Game
    {
        // het speelveld
        public FieldState[,] Grid { get; set; }
        // koppeling met form om items te kunnen plaatsen op de form
        public Form Form { get; set; }

        // constructor voor Games
        public Game(Form form)
        {
            // speelveld initialiseren met 6 rijen en 7 kolommen
            Grid = new FieldState[6, 7];
            Form = form;
        }

        // methode om de tokens op de form te plaatsen
        public void PlaceTokens()
        {
            Token t1 = new Token();
            t1.Location = new Point(0, 0); // references nodig naar System.Windows.Forms en System.Drawing
            Form.Controls.Add(t1); // token op form plaatsen
        }
    }
}
