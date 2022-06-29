using System;

namespace _02._Sum_Digits
{
    internal class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            while (number > 0)
            {
                int currentDigit = number % 10;
                number /= 10;
                sum += currentDigit;
            }
            Console.WriteLine(sum);
        }
    }
}
