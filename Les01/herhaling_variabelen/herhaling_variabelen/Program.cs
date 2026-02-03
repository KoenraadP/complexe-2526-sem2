using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace herhaling_variabelen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // enkele variabelen aanmaken
            // dit zijn allemaal variabelen met 'value' types
            // value types --> standaard types zoals bool, int, double, char, ...
            char character = 'a';
            bool check = false;
            double number = 5.55;
            decimal cash = 7.99M;

            // waarden tonen in console
            Console.WriteLine(cash);
            Console.WriteLine(check);

            // waarde van number veranderen via console
            //Console.WriteLine("Typ een cijfer in:");
            //number = Convert.ToDouble(Console.ReadLine());

            // controleren wat nu de waarde is van number
            //Console.WriteLine("De nieuwe waarde van number is " + number);

            // variabele aanmaken van type string
            // dit is een 'reference type'
            // reference types --> string, array, eigen classes, object, ...
            string name = "Koenraad";
            Student student1 = new Student(name);

            // naam van student1 tonen in console
            Console.WriteLine(student1.Name);

            // methodes uitvoeren
            ChangeNumber(number); // in deze methode wordt number op 20 ingesteld
            ChangeName(student1); // in deze methode wordt de naam op Ehsanullah ingesteld

            // opnieuw de waarden tonen in console
            // value types --> niet veranderd
            // reference types --> wel veranderd
            Console.WriteLine(number);
            Console.WriteLine(student1.Name);

            // string met speciale karakters
            // \test
            string special = @"\test";
            Console.WriteLine(special);
        }    
        
        // class Student aanmaken
        public class Student
        {
            // eigenschappen van Student
            public string Name { get; set; }

            // constructor voor Student
            public Student(string name)
            {
                Name = name;
            }
        }

        #region methods

        // methode om een opgegeven double te veranderen naar een andere waarde
        private static void ChangeNumber(double numberToChange)
        {
            numberToChange = 20;
        }

        // methode om een opgegeven naam van een student te veranderen naar een andere waarde
        private static void ChangeName(Student studentToChange)
        {
            studentToChange.Name = "Ehsanullah";
        }

        #endregion
    }
}
