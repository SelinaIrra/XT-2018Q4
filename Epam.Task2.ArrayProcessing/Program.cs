using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2.ArrayProcessing
{
    class Program
    {
        static void Sort(ref int[] array)
        {
            Sort(ref array, 0, array.Length);
        }

        static void Sort(ref int[] array, int begin, int end)
        {
            int length = end - begin;
            if (length < 2)
                return;
            Random random = new Random();
            int mid = begin + random.Next() % length;

            int left = begin,
                right = end - 1;
            while (left != mid && right != mid)
            {
                if (array[left] < array[mid])
                {
                    left++;
                    continue;
                }
                if (array[right] >= array[mid])
                {
                    right--;
                    continue;
                }
                Swap(ref array, left, right);
                left++;
                right--;
            }
            for (int i = mid - 1; i >= left; i--)
                if (array[i] > array[mid])
                {
                    for (int j = i; j < mid; j++)
                        Swap(ref array, j, j + 1);
                    mid--;
                }
            for (int i = mid + 1; i <= right; i++)
                if (array[i] < array[mid])
                {
                    for (int j = i; j > mid; j--)
                        Swap(ref array, j, j - 1);
                    mid++;
                }
            Sort(ref array, begin, mid);
            Sort(ref array, mid + 1, end);
        }

        static void Swap(ref int[] array, int index1, int index2)
        {
            int tmp = array[index1];
            array[index1] = array[index2];
            array[index2] = tmp;
        }

        static void PrintArray(ref int[] array)
        {
            if (CheckIfEmpty(ref array))
                return;
            for (int i = 0; i < array.Length; i++)
                Console.Write($"{array[i]}  ");
            Console.WriteLine();
        }

        static void PrintMax(ref int[] array)
        {
            if (CheckIfEmpty(ref array))
                return;
            int pos_max = 0;
            for (int i = 1; i < array.Length; i++)
                if (array[i] > array[pos_max])
                    pos_max = i;
            Console.WriteLine(array[pos_max]);
        }

        static void PrintMin(ref int[] array)
        {
            if (CheckIfEmpty(ref array))
                return;
            int pos_min = 0;
            for (int i = 1; i < array.Length; i++)
                if (array[i] < array[pos_min])
                    pos_min = i;
            Console.WriteLine(array[pos_min]);
        }

        static bool CheckIfEmpty(ref int[] array)
        {
            if (array.Length == 0)
            {
                Console.WriteLine("NULL");
                return true;
            }
            return false;
        }

        static void Main(string[] args)
        {
            Random random = new Random();
            UInt32.TryParse(Console.ReadLine(), out uint n);
            int[] array = new int[n];
            for (uint i = 0; i < n; i++)
                array[i] = random.Next(-250, 250);
            Console.WriteLine("Generated array:");
            PrintArray(ref array);

            Console.Write("Max value: ");
            PrintMax(ref array);

            Console.Write("Min value: ");
            PrintMin(ref array);

            Sort(ref array);
            Console.WriteLine("Sorted array:");
            PrintArray(ref array);
        }
    }
}
