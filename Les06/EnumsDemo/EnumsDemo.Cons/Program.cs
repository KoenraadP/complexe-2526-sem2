using EnumsDemo.Entities;
using System;

namespace EnumsDemo.Cons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // enum season uittesten
            Console.WriteLine(Season.Winter);

            // enum dag uittesten
            Console.WriteLine(Convert.ToInt32(Dag.Zondag));

            // omgekeerd --> cijfer omzetten naar season enum type
            Console.WriteLine((Season)2);

            Console.WriteLine(Country.BE);
            Console.WriteLine((Country)22);
            Console.WriteLine(Country.BE.GetEnumDescription());

            // eigenschappen van person vooraf aanmaken
            Guid id = Guid.NewGuid();
            string name = "Koenraad Pecceu";
            Address address = new Address
            {
                StreetName = "Scheutistenlaan",
                HouseNumber = "12",
                City = "Kortrijk",
                PostalCode = "8500"
            };
            //Address address2 = new Address();
            //address2.StreetName = ...
            Country country = Country.BE;

            Person p = new Person(id, name, address, country);
            Console.WriteLine(p.PersonId);
            Console.WriteLine(p.ToString());
        }
    }
}
