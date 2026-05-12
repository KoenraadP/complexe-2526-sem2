using System.Drawing;
using System.Windows.Forms;

namespace Connect4.Entities
{
    public class Token : Panel // komt uit System.Windows.Forms
    {
        // vaste waarden voor breedte en hoogte in constructor
        public Token()
        {
            Width = 50;
            Height = 50;
            BackColor = Color.Red; // komt uit System.Drawing
        }
    }
}
