using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task1.Simple
{
    class Program
    {
        static bool IsPrime(uint n)
        {
            for (uint i = 2; i * i <= n; i++)
                if (n % i == 0)
                    return false;
            return n > 1;
        }
        static void Main(string[] args)
        {
            if (UInt32.TryParse(Console.ReadLine(), out uint n))
            {
                if (IsPrime(n))
                    Console.WriteLine("It's prime number");
                else
                    Console.WriteLine("It's not prime number");
            }
            else
                Console.WriteLine("Incorrect input");
        }
    }
}
