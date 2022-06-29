using System;

namespace _03._Exact_Sum_of_Real_Numbers
{
    internal class Program
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            decimal sum = 0M;
            for (int i = 1; i <= count; i++)
            {
                sum += decimal.Parse(Console.ReadLine());
            }
            Console.WriteLine(sum);
        }
    }
}
