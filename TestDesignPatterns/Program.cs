using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var eiland = Eiland.GetEiland();
            Console.WriteLine("Wil je een vulkaanuitbarsting veroorzaken op het eiland? J/N");
            if (Console.ReadLine().ToUpper() == "J")
            {
                eiland.Uitbarsting();
                Console.ReadLine();
            }
        }
    }
}
