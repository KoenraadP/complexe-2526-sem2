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
        }
    }
}
