using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.App
{
    // polygon = 'veelhoek'
    // overerven met dubbelpunt --> alle properties, constructors, methodes, ... komen over van base class
    internal class Polygon : Shape
    {
        // aparte properties die niet in de base class zitten
        public int Height { get; set; }

        public Polygon(string color) : base(color)
        {
            
        }

        // color komt uit de base class
        public Polygon(int height, string color) : base(color) 
        {
            Height = height;
        }

        // als je een polygon opvraagt in de console
        // krijg je nu deze string te zien
        public override string ToString()
        {
            return "Dit is een veelhoek.";
        }
    }
}
