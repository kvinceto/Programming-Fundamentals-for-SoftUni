using System;
using System.Linq;

namespace _03._Rounding_Numbers
{
    internal class Program
    {
        static void Main()
        {
            string[] stringNumbers = Console.ReadLine().Split(' ');
            double[] numbers = new double[stringNumbers.Length];
            for (int i = 0; i < stringNumbers.Length; i++)
            {
                numbers[i] = double.Parse(stringNumbers[i]);

            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"{numbers[i]} => {(int)Math.Round(numbers[i], MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
