using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2.FontAdjustment
{
    class Program
    {
        static void PrintOptionName(int option)
        {
            switch (option)
            {
                case 1:
                    Console.Write("Bold");
                    break;
                case 2:
                    Console.Write("Italic");
                    break;
                case 3:
                    Console.Write("Underline");
                    break;
            }
        }

        static void Main(string[] args)
        {
            bool[] fontOptions = new bool[3] { false, false, false };
            while (true)
            {
                Console.Write("Параметры надписи: ");
                bool firstOption = true;
                for (int i = 0; i < 3; i++)
                    if (fontOptions[i])
                    {
                        if (!firstOption)
                            Console.Write(", ");
                        PrintOptionName(i + 1);
                        firstOption = false;
                    }
                if (firstOption)
                    Console.Write("None");
                Console.Write("\nВведите:");
                for (int i = 1; i <= 3; i++)
                {
                    Console.Write($"\n\t{i}: ");
                    PrintOptionName(i);
                }
                Console.WriteLine();
                if (UInt32.TryParse(Console.ReadLine(), out uint option))
                {
                    if (option > 3 || option < 1)
                        break;
                    option--;
                    fontOptions[option] = !fontOptions[option];
                }
                else
                    break;

            }
        }
    }
}
