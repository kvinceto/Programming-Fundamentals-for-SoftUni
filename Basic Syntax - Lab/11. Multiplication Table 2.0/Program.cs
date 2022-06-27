using System;

namespace _11._Multiplication_Table_2._0
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int i = int.Parse(Console.ReadLine());

            do
            {
                int result = n * i;
                Console.WriteLine($"{n} X {i} = {result}");
                i++;
            } while (i <= 10);
        }
    }
}