using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2.SumOfNumbers
{
    class Program
    {
        static uint Sum(uint div)
        {
            uint ans = 0;
            for (uint i = div; i < 1000; i += div)
                ans += i;
            return ans;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Sum(3) + Sum(5) - Sum(15));
        }
    }
}
