using System;
using System.Linq;

namespace _06._Equal_Sum
{
    internal class Program
    {
        static void Main()
        {
            int[] numberArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < numberArray.Length; i++)
            {
                if (numberArray.Length == 1)
                {
                    Console.WriteLine(0);
                    return;
                }

                leftSum = 0;
                for (int sumOfLeft = i; sumOfLeft > 0; sumOfLeft--)
                {
                    int nextLeftElement = sumOfLeft - 1;
                    if (nextLeftElement >= 0)
                    {
                        leftSum += numberArray[nextLeftElement];
                    }
                }
                rightSum = 0;
                for (int sumOfRight = i; sumOfRight < numberArray.Length; sumOfRight++)
                {
                    int nextRightElement = sumOfRight + 1;
                    if (sumOfRight < numberArray.Length - 1)
                    {
                        rightSum += numberArray[nextRightElement];
                    }
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }

            Console.WriteLine("no");
        }
    }
}
