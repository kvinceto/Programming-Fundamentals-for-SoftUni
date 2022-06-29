using System;

namespace _02._From_Left_to_The_Right
{
    internal class Program
    {
        static void Main()
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberOfLines; i++)
            {
                string[] input = Console.ReadLine().Split(" ");
                long leftNumber = long.Parse(input[0]);
                long rightNumber = long.Parse(input[1]);
                if (leftNumber >= rightNumber)
                {
                    long sumOfDigits = 0;
                    while (leftNumber != 0)
                    {
                        long digit = leftNumber % 10;
                        leftNumber /= 10;
                        sumOfDigits += digit;
                    }

                    Console.WriteLine(Math.Abs(sumOfDigits));
                    continue;
                }
                else
                {
                    long sumOfDigits = 0;
                    while (rightNumber != 0)
                    {
                        long digit = rightNumber % 10;
                        rightNumber /= 10;
                        sumOfDigits += digit;
                    }

                    Console.WriteLine(Math.Abs(sumOfDigits));
                    continue;
                }

            }
        }
    }
}
