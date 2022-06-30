using System;

namespace _09._Greater_of_Two_Values
{
    internal class Program
    {
        static void Main()
        {
            string inputType = Console.ReadLine();
            string inputFirstValue = Console.ReadLine();
            string inputSecondValue = Console.ReadLine();

            if (inputType == "int")
            {
                Console.WriteLine(GetMax(int.Parse(inputFirstValue), int.Parse(inputSecondValue)));
            }
            else if (inputType == "char")
            {
                Console.WriteLine(GetMax(char.Parse(inputFirstValue), char.Parse(inputSecondValue)));
            }
            else if (inputType == "string")
            {
                Console.WriteLine(GetMax(inputFirstValue, inputSecondValue));
            }
           
        }

        private static int GetMax(int firstNum, int secondNum)
        {
           return Math.Max(firstNum, secondNum);
        }
        private static char GetMax(char firstChar, char secondChar)
        {
            if (firstChar > secondChar)
            {
                return firstChar;
            }
            else
            {
                return secondChar;
            }
        }
        private static string GetMax(string firstInput, string secondInput)
        {
            int result = firstInput.CompareTo(secondInput);
            if (result > 0)
            {
                return firstInput;
            }
            else
            {
                return secondInput;
            }
        }
    }
}
