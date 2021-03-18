using System;

namespace ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();

                if (input=="end")
                {
                    break;
                }

                char[] cArray = input.ToCharArray();
                string reverse = String.Empty;
                for (int i = cArray.Length - 1; i > -1; i--)
                {
                    reverse += cArray[i];
                }

                Console.WriteLine($"{input} = {reverse}");
            }
        }
    }
}
