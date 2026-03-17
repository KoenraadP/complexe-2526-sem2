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
        }
    }
}
