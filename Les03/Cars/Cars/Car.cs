using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    internal class Car
    {
        // properties (eigenschappen) van een auto
        public string Make { get; set; } // merk
        public string Model { get; set; }
        public int Year { get; set; } // bouwjaar
        public int MaxSpeed { get; set; }

        // constructor
        public Car(string make, string model, int year, int maxSpeed)
        {
            Make = make;
            Model = model;
            Year = year;
            MaxSpeed = maxSpeed;
        }

        // override voor to string
        public override string ToString()
        {
            return Make + " " + Model;
        }
    }
}
