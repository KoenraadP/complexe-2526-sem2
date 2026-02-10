using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double temperature = 7;

            //bool freezing;

            //if (temperature < 0)
            //{
            //    freezing = true;
            //}
            //else
            //{
            //    freezing = false;
            //}

            //if (temperature < 0) freezing = true;
            //else freezing = false;

            // werken met ternary operator
            bool freezing = temperature < 0 ? true : false;

            Console.WriteLine(freezing);

            // if else via ? gewoon onmiddellijk uitvoeren bij writeline
            Console.WriteLine(temperature < 0 ? "het vriest" : "het vriest niet");

            // controle levert sowieso altijd true of false op als resultaat
            Console.WriteLine(temperature < 0);

            //int.TryParse(Console.ReadLine(), out int temp2);
            //Console.WriteLine(temp2 < 0);

            // experimentje
            Console.WriteLine(int.TryParse(Console.ReadLine(), out int temp2) && temp2 < 0);

            int a = 200;
            int b = 100;

            Console.WriteLine(LargestNumber(a, b));
        }

        private static int LargestNumber(int x, int y)
        {
            //int c;
            //if (x > y) c = x;
            //else c = y;
            //return c;
            //int z = x > y ? x : y;
            //return z;
            return x > y ? x : y;
        }
    }
}
