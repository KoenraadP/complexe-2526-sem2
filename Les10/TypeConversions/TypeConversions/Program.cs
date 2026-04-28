using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // implicit conversion --> double is 'groter' dan int
            int nr1 = 9;
            double nr2 = nr1;

            // Byte Short Int Long Float Double
            // Bart Staat In Lange File Druk

            // MaxValue om grootste waarde te zien van ee type
            Console.WriteLine(short.MaxValue);

            Console.WriteLine(nr1);
            Console.WriteLine(nr2);

             
            double nr3 = 11.5;
            // explicit conversion met de Convert class, er wordt afgerond
            int nr4 = Convert.ToInt32(nr3);
            // een explicit 'cast' doen --> cijfers na de komma verdwijnen
            int nr5 = (int)nr3;

            Console.WriteLine(nr4);
            Console.WriteLine(nr5);

            // bankers' rounding --> bij .5 gaan we naar het EVEN getal kan zowel naar beneden als naar boven zijn
            // https://en.wikipedia.org/wiki/Rounding
            double nr6 = 10.5;
            int nr7 = Convert.ToInt32(nr6);
            Console.WriteLine(nr7);

            double nr8 = 9;
            decimal nr9 = (decimal)nr8;
            Console.WriteLine(nr9);

            // overflowexception -- waarde is te groot
            //double maxDouble = double.MaxValue;
            //decimal convertedDouble = (decimal)maxDouble;
            //Console.WriteLine(maxDouble);
            //Console.WriteLine(convertedDouble);

            // false is 0, alles boven 0 is true
            bool x = false;
            Console.WriteLine(Convert.ToByte(x));

            // opletten met casten
            int nr10 = 300;
            // convert zal niet lukken --> overflox (max waarde van byte is 255)
            //byte convertNr10 = Convert.ToByte(nr10);
            // cast lukt wel maar we verliezen data
            byte castNr10 = (byte)nr10;
            //Console.WriteLine(convertNr10);
            Console.WriteLine(castNr10);

            // omzetten naar datum kan ook met Convert
            string dateString = "28/04/2026";
            DateTime date = Convert.ToDateTime(dateString);
            Console.WriteLine(date);
            Console.WriteLine(date.ToShortDateString());
        }
    }
}
