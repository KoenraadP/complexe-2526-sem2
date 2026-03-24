using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace EnumsDemo.Entities
{
    public class Person
    {
        // id voor person
        public Guid PersonId { get; set; }
        public string Name { get; set; }
        // adres op basis van Address class
        public Address Address { get; set; }
        // country op basis van Country enum
        public Country Country { get; set; }

        public Person(Guid personId, string name,
            Address address, Country country)
        {
            PersonId = personId;
            Name = name;
            Address = address;
            Country = country;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
