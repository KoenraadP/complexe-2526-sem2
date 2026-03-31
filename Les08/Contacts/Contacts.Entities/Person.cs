using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Entities
{
    public class Person
    {
        // in het tekstbestand zal één rij dan ingesteld staan
        // als: id;firstname;lastname;email
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        // override ToString om naam in combobox te tonen
        public override string ToString()
        {
            return LastName + " " + FirstName;
        }
    }
}
