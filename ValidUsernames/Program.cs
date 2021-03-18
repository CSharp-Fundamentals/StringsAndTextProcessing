using System;
using System.Collections.Generic;

namespace ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ");

            foreach (string username in usernames)
            {
                if (IsValid(username))
                {
                    Console.WriteLine(username);
                }
            }
        }

        private static bool IsValid(string username)
        {
            return IsValidLength(username) && ContainsValidSymbols(username);
        }

        private static bool ContainsValidSymbols(string username)
        {
            foreach (char symbol in username)
            {
                if (!char.IsLetterOrDigit(symbol) &&
                    symbol != '_' &&
                    symbol != '-')
                {
                    return false;
                }
            }
            return true;
        }

        private static bool IsValidLength(string username)
        {
            return username.Length >= 3 && username.Length <= 16;
        }
    }
}
