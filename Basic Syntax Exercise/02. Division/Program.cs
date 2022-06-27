using System;

namespace _02._Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int num2 = num % 2;
            int num3 = num % 3;
            int num6 = num % 6;
            int num7 = num % 7;
            int num10 = num % 10;

            if (num10 == 0)
            {
                Console.WriteLine("The number is divisible by 10");
            }
            else if (num7 == 0)
            {
                Console.WriteLine("The number is divisible by 7");
            }
            else if (num6 == 0)
            {
                Console.WriteLine("The number is divisible by 6");
            }
            else if (num3 == 0)
            {
                Console.WriteLine("The number is divisible by 3");
            }
            else if (num2 == 0)
            {
                Console.WriteLine("The number is divisible by 2");
            }
            else
            {
                Console.WriteLine("Not divisible");
            }

        }
    }
}