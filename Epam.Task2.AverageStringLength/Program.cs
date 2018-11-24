using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2.AverageStringLength
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int currentWordLength = 0,
                lettersCount = 0,
                wordsCount = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (Char.IsSeparator(text, i) && currentWordLength > 0)
                {
                    lettersCount += currentWordLength;
                    currentWordLength = 0;
                    wordsCount++;
                }
                else if (Char.IsLetter(text, i))
                    currentWordLength++;
            }
            if (currentWordLength > 0)
            {
                lettersCount += currentWordLength;
                wordsCount++;
            }
            Console.WriteLine($"AVG word length: {(Double)lettersCount / wordsCount}");
        }
    }
}
