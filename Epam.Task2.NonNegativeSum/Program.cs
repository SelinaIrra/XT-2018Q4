using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2.NonNegativeSum
{
    class Program
    {
        static void PrintArray(ref int[] array)
        {
            for (int i = 0; i < array.Length; i++)
                Console.Write($"{array[i]}  ");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Random random = new Random();
            int n = random.Next(4, 10);
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
                array[i] = random.Next(-250, 250);
            Console.WriteLine("Generated array:");
            PrintArray(ref array);
            int sum = 0;
            for (int i = 0; i < n; i++)
                if (array[i] > 0)
                    sum += array[i];
            Console.WriteLine($"Non-negative sum: {sum}");
        }
    }
}
