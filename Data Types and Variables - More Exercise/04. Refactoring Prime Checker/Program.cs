using System;

namespace _04._Refactoring_Prime_Checker
{
    internal class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            for (int currentNum = 2; currentNum <= number; currentNum++)
            {
                bool isPrime = true;
                for (int divider = 2; divider < currentNum; divider++)
                {
                    if (currentNum % divider == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                Console.WriteLine(isPrime ? $"{currentNum} -> true" : $"{currentNum} -> false");
            }

        }
    }
}
