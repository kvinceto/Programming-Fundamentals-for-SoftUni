using System;
using System.Diagnostics.CodeAnalysis;

namespace _05._Add_and_Subtract
{
    internal class Program
    {
        static void Main()
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            int result = ResultNum(firstNum, secondNum, thirdNum);
            Console.WriteLine(result);
        }

        private static int ResultNum(int firstNum, int secondNum, int thirdNum)
        {
            int result = FinalResult(Sum(firstNum, secondNum), thirdNum);

            return result;
        }

        private static int FinalResult(int sum, int thirdNum)
        {
            int result = sum - thirdNum;
            return result;
        }

        private static int Sum(int firstNum, int secondNum)
        {
            int sumOfNums = firstNum + secondNum;
            return sumOfNums;
        }
    }
}
