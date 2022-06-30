using System;

namespace _07._NxN_Matrix___
{
    internal class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            PrintMatrics(num);
        }

        private static void PrintMatrics(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= num; j++)
                {
                    Console.Write($"{num} ");
                }
                Console.WriteLine();
            }
        }
    }
}
