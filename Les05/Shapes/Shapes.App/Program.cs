using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape shape1 = new Shape("Red");

            Polygon polygon1 = new Polygon("Blue");
            polygon1.Height = 10;
            Console.WriteLine(polygon1);            
        }
    }
}
