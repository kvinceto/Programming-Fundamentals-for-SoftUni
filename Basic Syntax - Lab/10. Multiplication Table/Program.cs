using System;

namespace _10._Multiplication_Table
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int result;
            for (int i = 1; i <= 10; i++)
            {
                result = n * i;
                Console.WriteLine($"{n} X {i} = {result}");
            }
        }
    }
}