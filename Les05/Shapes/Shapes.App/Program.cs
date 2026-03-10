using Shapes.Entities;
using System;

namespace Shapes.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape shape1 = new Shape("Red");

            Polygon polygon1 = new Polygon("Blue");
            polygon1.Height = 10;
            System.Console.WriteLine(polygon1);

            Rectangle rectangle1 = new Rectangle(5,10,"Purple");
            System.Console.WriteLine(rectangle1.Area());
            Console.WriteLine(rectangle1.Perimeter());

            Square square1 = new Square(6, "Orange");
            Console.WriteLine(square1.Area());
            Console.WriteLine(square1.Perimeter());

            Circle c = new Circle(6, "Orange");
            Console.WriteLine(c.Diameter);

            Triangle t = new Triangle();
        }
    }
}
