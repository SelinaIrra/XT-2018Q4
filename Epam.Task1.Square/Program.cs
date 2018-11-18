using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task1.Square
{
    class Program
    {
        static void PrintSquare(int n)
        {
            int center = n / 2;
            for (int i = 0; i < n; i++, Console.WriteLine())
                for (int j = 0; j < n; j++)
                    if (i == center && j == center)
                        Console.Write(' ');
                    else
                        Console.Write('*');
        }

        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            PrintSquare(n);
        }
    }
}
