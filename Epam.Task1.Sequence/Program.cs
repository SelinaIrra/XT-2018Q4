using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task1.Sequence
{
    class Program
    {
       static void PrintSequence(uint n)
        {
            for (uint i = 1; i < n; i++)
                Console.Write($"{i}, ");
            Console.WriteLine(n);
        }

        static void Main(string[] args)
        {
            if (UInt32.TryParse(Console.ReadLine(), out uint n))
                PrintSequence(n);
            else
                Console.WriteLine("Incorrect input");
        }
    }
}
