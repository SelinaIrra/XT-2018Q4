using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task1.Sequence
{
    class Program
    {
        static string Sequence(int n)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i < n; i++)
            {
                sb.Append(i);
                sb.Append(", ");
            }
            sb.Append(n);
            return sb.ToString();
        }

        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine(Sequence(n));
        }
    }
}
