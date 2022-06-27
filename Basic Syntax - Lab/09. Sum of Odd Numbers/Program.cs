using System;

namespace _09._Sum_of_Odd_Numbers
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            int sum = 0;
            for (int i = 1; i <= int.MaxValue; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                    sum += i;
                    counter++;
                    if (counter == n)
                    {
                        Console.WriteLine($"Sum: {sum}");
                        return;
                    }
                }
            }
        }
    }
}