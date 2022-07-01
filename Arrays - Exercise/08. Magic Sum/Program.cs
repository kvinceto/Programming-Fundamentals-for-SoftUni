using System;
using System.Linq;

namespace _08._Magic_Sum
{
    internal class Program
    {
        static void Main()
        {
            int[] numbersArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int numberToBeMatched = int.Parse(Console.ReadLine());

            for (int i = 0; i < numbersArray.Length - 1; i++)
            {
                for (int j = i+1; j < numbersArray.Length; j++)
                {

                    int currentNumber = numbersArray[i];
                    int nextNumber = numbersArray[j];
                    if (currentNumber + nextNumber == numberToBeMatched)
                    {
                        Console.WriteLine($"{currentNumber} {nextNumber}");
                    }
                }
            }
        }
    }
}
