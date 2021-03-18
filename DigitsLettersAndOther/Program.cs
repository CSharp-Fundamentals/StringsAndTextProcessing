using System;
using System.Text;

namespace DigitsLettersAndOther
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder numbers = new StringBuilder();
            StringBuilder letters = new StringBuilder();
            StringBuilder other = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i]>47 && input[i]<58)
                {
                    numbers.Append(input[i]);
                }
                else if (input[i]>64 && input[i]<91 || input[i]>96 && input[i]<123)
                {
                    letters.Append(input[i]);
                }
                else
                {
                    other.Append(input[i]);
                }
            }
            Console.WriteLine(numbers);
            Console.WriteLine(letters);
            Console.WriteLine(other);
        }
    }
}
