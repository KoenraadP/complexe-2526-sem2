
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
            Console.WriteLine(lines[0]);

            return lstPeople;
        }
    }
}
