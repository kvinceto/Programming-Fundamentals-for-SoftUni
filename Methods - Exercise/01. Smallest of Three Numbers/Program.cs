using System;

namespace _01._Smallest_of_Three_Numbers
{
    internal class Program
    {
        static void Main()
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            int minNum = MinNum(firstNum, secondNum, thirdNum);
            Console.WriteLine(minNum);
        }

        private static int MinNum(int firstNum, int secondNum, int thirdNum)
        {
            int minNum = Math.Min(firstNum, Math.Min(secondNum, thirdNum));
            return minNum;
        }
    }
}
