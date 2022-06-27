using System;

namespace _12._Even_Number
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            while (Math.Abs(n) % 2 != 0)
            {
                Console.WriteLine("Please write an even number.");
                n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"The number is: {Math.Abs(n)}");
        }
    }
}