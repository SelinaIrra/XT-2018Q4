using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2.NoPositive
{
    class Program
    {
        static void ReplacePositive(ref int[][][] array)
        {
            for (int i = 0; i < array.Length; i++)
                for (int j = 0; j < array[i].Length; j++)
                    for (int k = 0; k < array[i][j].Length; k++)
                        if (array[i][j][k] > 0)
                            array[i][j][k] = 0;
        }

        static void PrintArray(ref int[][][] array)
        {
            for (int i = 0; i < array.Length; i++, Console.WriteLine())
                for (int j = 0; j < array[i].Length; j++, Console.WriteLine())
                    for (int k = 0; k < array[i][j].Length; k++)
                        Console.Write($"{array[i][j][k]}\t");
        }

        static void Main(string[] args)
        {
            Random random = new Random();
            int n = random.Next(2, 6),
                m = random.Next(2, 6),
                z = random.Next(2, 6);
            Console.WriteLine($"Array dimension: {n} x {m} x {z}");
            int[][][] array = new int[n][][];
            for (int i = 0; i < n; i++)
            {
                array[i] = new int[m][];
                for (int j = 0; j < m; j++)
                {
                    array[i][j] = new int[z];
                    for (int k = 0; k < z; k++)
                        array[i][j][k] = random.Next(-250, 250);
                }
            }

            Console.WriteLine($"Generated array:");
            PrintArray(ref array);

            ReplacePositive(ref array);
            Console.WriteLine($"Result array:");
            PrintArray(ref array);
        }
    }
}
