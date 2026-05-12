using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace MultiDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // lege 1D array maken voor 9 int getallen
            int[] numbersArray = new int[9];
            Console.WriteLine(numbersArray[0]);

            // 1D int array maken met al enkele waarden in
            int[] numbersArray2 = { 10, 20, 30, 40 };

            // 1D string array
            string[] names = { "Mohammed", "Sohail",
                                "Kenny", "Ehsanullah",
                                "Yasin" };

            string[] studentsSimple = { "Mohammed", "327676",
                                   "Sohail", "339091"};

            // grootte van array tonen
            Console.WriteLine(studentsSimple.Length);

            string[,] students =
            {
                {"Mohammed", "327676"},
                {"Sohail", "339091" },
                {"Kenny", "337306" },
                {"Ehsanullah", "336996" },
                {"Yasin", "338972" },
            };

            // eerste (index 0) element uit tweede rij (index 1) ophalen
            Console.WriteLine(students[1,0]);
            // student id van Yasin tonen
            Console.WriteLine(students[4, 1]);

            // grootte van 2D array tonen
            Console.WriteLine(students.Length);
            // aantal rijen van 2D array tonen
            Console.WriteLine(students.GetLength(0));
            // aantal kolommen van 2D array tonen
            Console.WriteLine(students.GetLength(1));

            // alle waarden tonen met foreach
            foreach (var item in students)
            {
                Console.WriteLine(item);
            }

            // alle waarden tonen uit een 'gewone' array met gewone for loop
            for (int i = 0; i < studentsSimple.Length; i++)
            {
                Console.WriteLine(studentsSimple[i]);
            }

            // alle namen tonen uit students
            for (int i = 0; i < students.GetLength(0); i++)
            {
                Console.WriteLine(students[i,0]);
            }

            // alle id's tonen uit students
            for (int i = 0; i < students.GetLength(0); i++)
            {
                Console.WriteLine(students[i,1]);
            }

            // alle gegevens van de laatste persoon tonen
            // i = index kolom
            for (int i = 0; i < students.GetLength(1); i++)
            {
                int lastRow = students.GetLength(0) - 1;
                Console.WriteLine(students[lastRow, i]);
            }
        }
    }
}
