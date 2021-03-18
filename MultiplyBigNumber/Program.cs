using System;
using System.Numerics;

namespace MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger firstNumber = BigInteger.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            BigInteger sum = firstNumber * secondNumber;

            Console.WriteLine(sum);
        }
    }
}
