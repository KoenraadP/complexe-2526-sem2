using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.App
{
    // shape = 'vorm' (rechthoek, ellips, cirkel, driehoek, ...)
    public class Shape
    {
        // property 'kleur', iedere vorm heeft een kleur
        public string Color { get; set; }

        // constructor --> alle vormen en afgeleide classes moeten color invullen
        public Shape(string color)
        {
            Color = color;
        }
    }
}
