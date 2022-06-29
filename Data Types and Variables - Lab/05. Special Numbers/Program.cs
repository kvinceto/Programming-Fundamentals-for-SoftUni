using System;

namespace _05._Special_Numbers
{
    internal class Program
    {
        static void Main()
        {
            int numbersCount = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= numbersCount; i++)
            {
                int currentNumber = i;
                int sum = 0;
                while (currentNumber != 0)
                {
                    int digit = currentNumber % 10;
                    currentNumber /= 10;
                    sum += digit;
                }
                    if (sum == 5 || sum == 7 || sum == 11)
                    {
                        Console.WriteLine($"{i} -> True");
                    }
                    else
                    {
                        Console.WriteLine($"{i} -> False");
                    }
            }
        }
    }
}
