using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace herhaling_methodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Add methode uitvoeren
            int nr1 = 6;
            int nr2 = 5;
            int sum = Add(nr1, nr2);
            Console.WriteLine(sum);
            Console.WriteLine(Add(nr1, nr2));

            Console.WriteLine(Divide(nr1, nr2));

            double nr3 = 10.5;
            double nr4 = 11.6;
            Console.WriteLine(Add(nr3, nr4));
            Console.WriteLine(Add(nr2));

            CountdownToZero(10);
        }

        // methode om twee int cijfers op te tellen
        // resultaat moet uit de methode komen
        // private/public: access modifier
        // int: return type, kan ook void zijn als er geen return is
        // naam van de methode: altijd met hoofdletter beginnen
        // standaard waarde voor parameters met =
        private static int Add(int x, int y = 0)
        {
            // 'body' van de methode
            return x + y;
        }

        private static double Add(double x, double y)
        {
            return x + y;
            //return Convert.ToInt32(m + n);
        }

        // voorbeeld methode met 'recursion'
        // methode roept zichzelf aan binnen de methode body
        private static void CountdownToZero(int nr)
        {
            if (nr == 0)
            {
                Console.WriteLine("Done!");
                // return --> stopt de methode
                return;
            }

            Console.WriteLine(nr);
            CountdownToZero(nr - 1);
        }

        public static double Divide(int number1, int number2)
        {
            // maak hier je berekening, je zal de "int" waarden met behulp van Convert.ToDouble moeten omzetten naar kommagetallen => bvb. double x = Convert.ToDouble(100);
            // Controleer in deze methode ook of de 2 waarde groter is dan 0...want delen door 0 kan niet!
            // Als het tweede cijfer een 0 is, return dan gewoon -1

            if (number2 == 0) return -1;

            double result = 0;
            result = Convert.ToDouble(number1) / Convert.ToDouble(number2);
            return result;
        }
    }
}
