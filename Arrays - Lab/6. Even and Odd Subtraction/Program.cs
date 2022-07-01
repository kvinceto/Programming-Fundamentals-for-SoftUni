using System;
using System.Linq;

namespace _6._Even_and_Odd_Subtraction_
{
    internal class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int sumOdd = 0;
            int sumEven = 0;
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    sumEven += number;
                }
                else
                {
                    sumOdd += number;
                }
            }

            Console.WriteLine(sumEven - sumOdd);
        }
    }
}
