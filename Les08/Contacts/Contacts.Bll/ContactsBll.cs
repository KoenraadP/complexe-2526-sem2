
using Contacts.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Bll
{
    public static class ContactsBll
    {
        // methode om alle lijntjes uit een
        // tekstbestand te lezen en ieder lijntje
        // om te zetten naar een Person en dan
        // ook alle Person objecten in een List steken
        public static List<Person> LoadContacts(string fullPath) // fullPath zal bijvoorbeeld zijn "c:\contacten\creo.txt"
        {
            // lege list aanmaken om te beginnen
            List<Person> lstPeople = new List<Person>();

            // array voor ieder apart lijntje uit txt bestand
            string[] lines = File.ReadAllLines(fullPath);

            // testen wat er momenteel op index 0 in de array zit
            // Console.WriteLine(lines[0]);

            // ieder aparte lijn uit tekst verwerken
            foreach (string line in lines)
            {
                // array met vier aparte properties in: id, firstname, lastname, email
                string[] personData = line.Split(';');

                // data opslaan in Person variabele
                Person p = new Person
                {
                    Id = Convert.ToInt32(personData[0]),
                    FirstName = personData[1],
                    LastName = personData[2],
                    Email = personData[3],
                };

                // Person toevoegen aan de list
                lstPeople.Add(p);
            }

            return lstPeople;
        }

        // methode om de gegevens van een Person te updaten
        // parameters: Person met nieuwe data, list met Persons in
        public static void UpdateContacts(Person updatedPerson, List<Person> lstPeople)
        {
            // index van persoon opslaan die we moeten aanpassen
            // index = op welke plaats in de list staat de Person
            int index = updatedPerson.Id - 1;
            // persoon op juiste plaats in list 'vervangen' met nieuwe data
            lstPeople[index] = updatedPerson;
        }
    }
}
