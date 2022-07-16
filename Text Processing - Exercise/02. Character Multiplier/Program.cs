using System;
using System.ComponentModel.Design;
using System.Runtime.InteropServices.ComTypes;

namespace _02._Character_Multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int sumOfCharacters = SumAllTheCharactersValueInString(input[0], input[1]);

            Console.WriteLine(sumOfCharacters);

        }

        private static int SumAllTheCharactersValueInString(string firstInput, string secondInput)
        {
            int sum = 0;
            int iterations = Math.Min(firstInput.Length, secondInput.Length);

            for (int i = 0; i < iterations; i++)
            {
                int firstInputCharValue = (int)firstInput[0];
                int secondInputCharValue = (int)secondInput[0];
                firstInput = firstInput.Remove(0, 1);
                secondInput = secondInput.Remove(0, 1);
                sum += firstInputCharValue * secondInputCharValue;
            }

            if (firstInput.Length > 0)
            {
                sum += GetTheSumOfOtherChars(firstInput);
            }
            else if(secondInput.Length > 0)
            {
                sum += GetTheSumOfOtherChars(secondInput);
            }

            return sum;

        }

        private static int GetTheSumOfOtherChars(string input)
        {
            int sum = 0;
            int iterations = input.Length;
            for (int i = 0; i < iterations; i++)
            {
                sum += (int)input[0];
                input = input.Remove(0, 1);
            }
            return sum;
        }
    }
}
