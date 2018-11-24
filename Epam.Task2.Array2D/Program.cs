using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2.Array2D
{
    class Program
    {
        static void PrintArray(ref int[][] array)
        {
            for (int i = 0; i < array.Length; i++, Console.WriteLine())
                for (int j = 0; j < array[i].Length; j++)
                    Console.Write($"{array[i][j]}  ");
        }

        static void Main(string[] args)
        {
            Random random = new Random();
            int n = random.Next(3, 7),
                m = random.Next(3, 7);
            int[][] array = new int[n][];
            for (int i = 0; i < n; i++)
            {
                array[i] = new int[m];
                for (int j = 0; j < m; j++)
                    array[i][j] = random.Next(-250, 250);
            }
            Console.WriteLine("Generated array");
            PrintArray(ref array);
            int sum = 0;
            for (int i = 0; i < n; i++)
                for (int j = i % 2; j < m; j += 2)
                    sum += array[i][j];
            Console.WriteLine($"Even sum: {sum}");
        }
    }
}
