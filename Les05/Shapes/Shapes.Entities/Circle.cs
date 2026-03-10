using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.App
{
    public class Circle : Ellipse
    {

        public int Diameter
        {
            get { return Width; }
            set
            {
                Width = value;
                Height = value;
            }
        }

        public Circle(int diameter, string color) : base(diameter, diameter, color)
        {
        }

        // alternatief
        /*public int Diameter { get; set; }
         * 
        public Circle(int diameter, string color) : base(diameter, diameter, color)
        {
            Diameter = diameter;
        }*/
    }
}
