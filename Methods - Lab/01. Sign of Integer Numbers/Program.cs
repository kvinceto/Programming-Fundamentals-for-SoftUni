using System;

namespace _01._Sign_of_Integer_Numbers
{
    internal class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            PrintSign(number);
        }

        static void PrintSign(int num)
        {
            if (num > 0)
            {
                Console.WriteLine($"The number {num} is positive.");
            }
            else if (num == 0)
            {
                Console.WriteLine($"The number {num} is zero.");   
            }
            else
            {
                Console.WriteLine($"The number {num} is negative.");
            }
        }
    }
}
