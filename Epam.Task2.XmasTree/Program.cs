using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2.XmasTree
{
    class Program
    {
        static void PrintTree(uint n)
        {
            for (uint i = 1; i <= n; i++)
                for (uint j = 1; j <= i; j++, Console.WriteLine())
                {
                    for (uint k = 0; k < n - j; k++)
                        Console.Write(" ");
                    for (uint k = 0; k < j * 2 - 1; k++)
                        Console.Write("*");
                    for (uint k = 0; k < n - j; k++)
                        Console.Write(" ");
                }
        }

        static void Main(string[] args)
        {
            if (UInt32.TryParse(Console.ReadLine(), out uint n))
                PrintTree(n);
            else
                Console.WriteLine("Incorrect input");
        }
    }
}
