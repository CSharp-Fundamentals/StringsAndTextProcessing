using System;

namespace CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            int result = MultiplyWords(words[0], words[1]);

            Console.WriteLine(result);
        }

        private static int MultiplyWords(string first, string second)
        {
            int minLength = Math.Min(first.Length, second.Length);
            int sum = 0;

            for (int i = 0; i < minLength; i++)
            {
                sum += first[i] * second[i];
            }

            if (first.Length>second.Length)
            {
                sum += SumRemainingCharacter(first, minLength);
            }
            else if (second.Length>first.Length)
            {
                sum += SumRemainingCharacter(second,minLength);
            }

            return sum;
        }

        private static int SumRemainingCharacter(string word, int index)
        {
            int sum = 0;

            for (int i = index; i < word.Length; i++)
            {
                sum += word[i];
            }
            return sum;
        }
    }
}
