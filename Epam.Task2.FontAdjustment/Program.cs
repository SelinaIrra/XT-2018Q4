using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2.FontAdjustment
{
    class Program
    {
        static FontState GetFont(int index)
        {
            if (index == 3)
                return (FontState)(index + 1);
            return (FontState)index;
        }

        static void Main(string[] args)
        {
            FontState fontState = FontState.None;
            while (true)
            {
                Console.WriteLine($"Параметры надписи: {fontState.ToString()}");
                Console.WriteLine("Введите:");
                for (int i = 1; i <= 3; i++)
                    Console.WriteLine($"\t{i}: {GetFont(i)}");
                if (Int32.TryParse(Console.ReadLine(), out int option))
                {
                    if (option > 3 || option < 1)
                        break;
                    fontState = fontState ^ GetFont(option);
                }
                else
                    break;
            }
        }

        [Flags]
        enum FontState
        {
            None = 0,
            Bold = 1,
            Italic = 2,
            Underline = 4
        }
    }
}
