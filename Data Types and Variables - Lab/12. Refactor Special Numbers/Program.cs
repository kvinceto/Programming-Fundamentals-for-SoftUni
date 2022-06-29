using System;

namespace _12._Refactor_Special_Numbers
{
    internal class Program
    {
        static void Main()
        {
            int numbers = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numbers; i++)
            {
                int number = i;
                int sum = 0;
                while (number > 0)
                {
                    sum += number % 10;
                    number /= 10;
                }
                bool isSpecial = (sum == 5) || (sum == 7) || (sum == 11);
                if (isSpecial)
                {
                    Console.WriteLine($"{i} -> {isSpecial}");
                }
                else
                {
                    Console.WriteLine($"{i} -> {isSpecial}");
                }
            }

        }
    }
}
