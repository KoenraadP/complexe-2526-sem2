using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.App
{
    // shape = 'vorm' (rechthoek, ellips, cirkel, driehoek, ...)
    internal class Shape
    {
        // property 'kleur', iedere vorm heeft een kleur
        public string Color { get; set; }

        public Shape(string color)
        {
            Color = color;
        }
    }
}
