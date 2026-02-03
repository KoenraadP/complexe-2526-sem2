using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herhaling_operatoren
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            x++;
            Console.WriteLine(x); // 6
            Console.WriteLine(x++); // 6
            Console.WriteLine(x); // 7
            Console.WriteLine(++x); // 8
        }
    }
}
