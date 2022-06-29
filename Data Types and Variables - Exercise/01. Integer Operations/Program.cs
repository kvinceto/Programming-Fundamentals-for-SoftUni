using System;

namespace _01._Integer_Operations
{
    internal class Program
    {
        static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int fourthNumber = int.Parse(Console.ReadLine());
            int sum = ((firstNumber + secondNumber) / thirdNumber) * fourthNumber;
            Console.WriteLine(sum);
        }
    }
}
