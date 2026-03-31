using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Entities
{
    internal class Person
    {
        // in het tekstbestand zal één rij dan ingesteld staan
        // als: id;firstname;lastname;email
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}
