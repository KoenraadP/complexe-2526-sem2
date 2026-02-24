using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herhaling_trycatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // array met 12 plaatsen voor string elementen
                string[] months = new string[12];
                months[0] = "January";
                //int number = Convert.ToInt32(months[0]);
                months[12] = "December";
            }
            catch (FormatException) // fout bij data types, conversie, ...
            {
                Console.WriteLine("Data type klopt niet!");
            }
            catch (IndexOutOfRangeException) // fout bij indexes van array
            {
                Console.WriteLine("Je zit buiten de grenzen van je array!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Er is een fout opgetreden: " + ex.Message);
            }
            finally // dit wordt altijd uitgevoerd
            {
                Console.WriteLine("Dit is het einde!");
            }
        }
    }
}
