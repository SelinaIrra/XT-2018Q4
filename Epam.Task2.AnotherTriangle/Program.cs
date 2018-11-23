using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2.AnotherTriangle
{
    class Program
    {
        static void PrintTriangle(uint n)
        {
            for (uint i = 1; i <= n; i++, Console.WriteLine())
            {
                for (uint j = 0; j < n - i; j++)
                    Console.Write(" ");
                for (uint j = 0; j < i * 2 - 1; j++)
                    Console.Write("*");
                for (uint j = 0; j < n - i; j++)
                    Console.Write(" ");
            }
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
