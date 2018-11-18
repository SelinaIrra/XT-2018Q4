using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task1.Simple
{
    class Program
    {
        static bool IsPrime(int n)
        {
            for (int i = 2; i * i <= n; i++)
                if (n % i == 0)
                    return false;
            return true;
        }
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            if (IsPrime(n))
                Console.WriteLine("it is prime number");
            else
                Console.WriteLine("it is not prime number");
        }
    }
}
