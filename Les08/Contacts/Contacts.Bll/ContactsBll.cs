
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
                // een line is bijvoorbeeld: 0;Koenraad;Pecceu;koenraad.pecceu@creo.be
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

        // methode om de inhoud van de volledige list 
        // opnieuw op te slaan in het tekstbestand
        // fullpath --> het volledige pad naar het bestand bvb c:\contacten\creo.text
        // lstPeople --> de huidige list met alle personen in
        public static void UpdateFile(string fullPath, List<Person> lstPeople)
        {
            // om de WriteAllLines() te kunnen gebruiken, moeten we
            // een string[] array voorzien, deze maken we hier al aan
            string[] newLines = new string[lstPeople.Count]; // .Count = aantal items in de list

            // alle Person objecten uit de list opnieuw omzetten
            // naar één string lijntje met de correcte 'syntax'
            // voor het tekstbestand --> id;voornaam;achternaam;e-mail
            foreach(Person p in lstPeople)
            {
                string line = p.Id + ";"
                            + p.FirstName + ";"
                            + p.LastName + ";"
                            + p.Email;
                // string op de juiste plaats in de array zetten
                newLines[p.Id - 1] = line;
            }

            // inhoud van array in txt file plaatsen
            File.WriteAllLines(fullPath, newLines);
        }
    }
}
