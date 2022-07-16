using System;
using System.Numerics;

namespace _05._Multiply_Big_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BigInteger number = BigInteger.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());

            Console.WriteLine(number * multiplier);
        }
    }
}
