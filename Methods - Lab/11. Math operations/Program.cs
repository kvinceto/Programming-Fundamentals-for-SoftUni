using System;
using System.Runtime.Intrinsics.Arm;
using System.Threading;

namespace _11._Math_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            char currentOperator = char.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double result = 0;
            switch (currentOperator)
            {
                case '/':
                    result = firstNumber / secondNumber;
                    break;
                case '*':
                    result = firstNumber * secondNumber;
                    break;
                case '+':
                    result = firstNumber + secondNumber;
                    break;
                case '-':
                    result = firstNumber - secondNumber;
                    break;
            }

            Console.WriteLine(result);
        }
    }
}
