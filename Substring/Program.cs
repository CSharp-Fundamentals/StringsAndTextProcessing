using System;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string removeWord = Console.ReadLine();
            string text = Console.ReadLine();

            while (text.Contains(removeWord))
            {
                int index = text.IndexOf(removeWord);
                text = text.Remove(index,removeWord.Length);
            }

            Console.WriteLine(text);
        }
    }
}
