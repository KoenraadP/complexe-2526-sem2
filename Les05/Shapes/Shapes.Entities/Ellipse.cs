using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.App
{
    public class Ellipse : Shape
    {       
        public int Height { get; set; }
        public int Width { get; set; }

        public Ellipse(int height, int width, string color) : base(color)
        {
            Height = height;
            Width = width;
        }
    }
}
