using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.App
{
    public class Rectangle : Polygon
    {
        // unieke properties voor rectangle
        public int Width { get; set; }

        public Rectangle(string color) : base(color)
        {
        }

        public Rectangle(int width, int height, string color) : base(height, color)
        {
            Width = width;
        }

        // methodes die oppervlakte en omtrek berekenen van een rechthoek
        public int Area()
        {
            return Width * Height;
        }

        public int Perimeter()
        {
            return 2 * (Width + Height);
        }
    }
}
