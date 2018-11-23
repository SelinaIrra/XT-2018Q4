using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2.Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            bool correct_input = Double.TryParse(Console.ReadLine(), out double a);
            correct_input = Double.TryParse(Console.ReadLine(), out double b) && correct_input;
            if (correct_input)
                if (a <= 0 || b <= 0)
                    Console.WriteLine(a * b);
                else
                    Console.WriteLine("Incorect rectangle side value");
            else
                Console.WriteLine("Incorect input");
        }
    }
}
