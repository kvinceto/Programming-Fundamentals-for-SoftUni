using System;

namespace _10._Multiply_Evens_by_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));

            int sumOfEvenDigits = GetSumOfEvenDigits(number);
            int sumOfOddDigits = GetSumOfOddDigits(number);
            Console.WriteLine(sumOfOddDigits * sumOfEvenDigits);

        }

        private static int GetSumOfOddDigits(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int currentDigit = number % 10;
                number /= 10;
                if (currentDigit % 2 != 0)
                {
                    sum += currentDigit;
                }
            }
            return sum;
        }

        private static int GetSumOfEvenDigits(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int currentDigit = number % 10;
                number /= 10;
                if (currentDigit % 2 == 0)
                {
                    sum += currentDigit;
                }
            }
            return sum;
        }
    }
}
