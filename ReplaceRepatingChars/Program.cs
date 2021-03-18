using System;
using System.Text;

namespace ReplaceRepatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            char previousSymbol = '\0';

            StringBuilder result = new StringBuilder();

            foreach (char letter in line)
            {
                if (letter != previousSymbol)
                {
                    result.Append(letter);
                }
                previousSymbol = letter;
            }

            Console.WriteLine(result);
        }
    }
}
