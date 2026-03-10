using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.App
{
    internal class Square : Rectangle
    {
        public Square(string color) : base(color)
        {
        }

        // een vierkant heeft geen aparte width/height nodig
        // we vullen dus dezelfde waarde in voor beide properties van de base constructor
        public Square(int side, string color) : base(side, side, color)
        {
        }
    }
}
