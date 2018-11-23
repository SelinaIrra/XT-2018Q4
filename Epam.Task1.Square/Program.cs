using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task1.Square
{
    class Program
    {
        static void PrintSquare(uint n)
        {
            uint center = n / 2;
            for (uint i = 0; i < n; i++, Console.WriteLine())
                for (uint j = 0; j < n; j++)
                    if (i == center && j == center)
                        Console.Write(' ');
                    else
                        Console.Write('*');
        }

        static void Main(string[] args)
        {
            if (UInt32.TryParse(Console.ReadLine(), out uint n))
            {
                if (n % 2 == 1)
                    PrintSquare(n);
                else
                    Console.WriteLine("Number is even");
            }
            else
                Console.WriteLine("Incorrect input");
        }
    }
}
