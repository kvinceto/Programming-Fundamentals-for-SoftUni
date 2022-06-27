using System;

namespace _06._Strong_number
{
    internal class Program
    {
        static void Main()
        {
            int inputNumber = int.Parse(Console.ReadLine());
            int copyOfInputNumber = inputNumber;
            int sum = 0;

            while (inputNumber != 0)
            {
                int lastDigit = inputNumber % 10;
                inputNumber /= 10;
                int currentDigitFactorial = 1;
                for (int i = 1; i <= lastDigit; i++)
                {
                    currentDigitFactorial *= i;
                }
                sum += currentDigitFactorial;
            }
            Console.WriteLine(copyOfInputNumber == sum ? "yes" : "no");
        }
    }
}