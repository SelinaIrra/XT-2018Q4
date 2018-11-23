using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2.Triangle
{
    class Program
    {
        static void PrintTriangle(uint n)
        {
            for (uint i = 1; i <= n; i++, Console.WriteLine())
                for (uint j = 1; j <= i; j++)
                    Console.Write("*");
        }

        static void Main(string[] args)
        {
            if (UInt32.TryParse(Console.ReadLine(), out uint n))
                PrintTriangle(n);
            else
                Console.WriteLine("Incorrect input");
        }
    }
}
