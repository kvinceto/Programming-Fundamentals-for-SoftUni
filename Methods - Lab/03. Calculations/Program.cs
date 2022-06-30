using System;

namespace _03._Calculations
{
    internal class Program
    {
        static void Main()
        {
            string action = Console.ReadLine();
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            if (action == "add")
            {
                Add(firstNumber, secondNumber);
            }
            else if (action == "multiply")
            {
                Multiply(firstNumber, secondNumber);
            }
            else if (action == "subtract")
            {
                Subtract(firstNumber, secondNumber);
            }
            else if (action == "divide")
            {
                Divide(firstNumber, secondNumber);
            }
        }

        static void Divide(int firstNumber, int secondNumber)
        {
            int result = firstNumber / secondNumber;
            Console.WriteLine(result);
        }

        static void Add(int num1, int num2)
        {
            int sum = num1 + num2;
            Console.WriteLine(sum);
        }

        static void Multiply(int num1, int num2)
        {
            int result = num1 * num2;
            Console.WriteLine(result);
        }

        static void Subtract(int num1, int num2)
        {
            int result = num1 - num2;
            Console.WriteLine(result);
        }
    }
}
