using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2.CharDoubler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первую строку: ");
            string s1 = Console.ReadLine();
            Console.Write("Введите вторую строку: ");
            string s2 = Console.ReadLine();
            Console.Write("Результирующая строка: ");
            for (int i = 0; i < s1.Length; i++)
            {
                Console.Write(s1[i]);
                if (s2.Contains(s1[i]))
                    Console.Write(s1[i]);
            }
            Console.WriteLine();
        }
    }
}
