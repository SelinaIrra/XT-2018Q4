using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task1.Sequence
{
    class Program
    {
        static void PrintSequence(int n)
        {
            for (int i = 1; i < n; i++)
            {
                Console.Write(i);
                Console.Write(", ");
            }
            Console.WriteLine(n);
        }

        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            PrintSequence(n);
        }
    }
}
