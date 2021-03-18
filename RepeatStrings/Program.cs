using System;

namespace RepeatStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split();

            string output = string.Empty;

            foreach (var item in array)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    output += item;
                }
            }
            Console.WriteLine(output);
        }
    }
}