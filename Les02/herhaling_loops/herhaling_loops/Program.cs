using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herhaling_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // variabele voor teller, nog niet ingevuld
            int i;

            // van 0 tot en met 10
            for (i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            // van 0 tot en met 10
            i = 0;
            while (i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }            

            // enkel oneven getallen --> 1 3 5 7 9
            for (i = 1; i <= 10; i += 2)
            {
                //if (i % 2 != 0)
                //{
                //    Console.WriteLine(i);
                //}

                Console.WriteLine(i);
            }

            // versie met do while
            i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i <= 10);

            // array aanmaken met daarin 10 random cijfers
            // vanaf 1 tot en met 100
            int[] randomNumbers = new int[10];
            //string[] randomText = new string[10];
            Random rand = new Random();
            for (i = 0; i < randomNumbers.Length; i++)
            {
                randomNumbers[i] = rand.Next(1,101);
            }
            foreach (var item in randomNumbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
