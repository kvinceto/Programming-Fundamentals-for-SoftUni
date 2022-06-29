using System;
using System.Runtime.InteropServices.ComTypes;

namespace _03._Floating_Equality
{
    internal class Program
    {
        static void Main()
        {
            const decimal EPS = 0.000001m;
            decimal firstNumber = decimal.Parse(Console.ReadLine());
            decimal secondNumber = decimal.Parse(Console.ReadLine());
            decimal difference;

            if (firstNumber >= secondNumber)
            {
                difference = firstNumber - secondNumber;
            }
            else
            {
                difference = secondNumber - firstNumber;
            }

            bool  result = difference < EPS ? true : false;
            Console.WriteLine(result);
        }
    }
}
