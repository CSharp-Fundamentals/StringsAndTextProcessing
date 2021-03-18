using System;
using System.Text;

namespace StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            StringBuilder result = new StringBuilder();
            int bomb = 0;
            for (int i = 0; i < line.Length; i++)
            {
                if ((line[i] == '>'))
                {
                    bomb += line[i + 1] - '0';
                    result.Append(line[i]);
                }
                else if(bomb>0)
                {
                    bomb--;
                }
                else
                {
                    result.Append(line[i]);
                }
            }

            Console.WriteLine(result);
        }
    }
}
