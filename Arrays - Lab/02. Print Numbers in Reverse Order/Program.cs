using System;
using System.Linq;

namespace _02._Print_Numbers_in_Reverse_Order
{
    internal class Program
    {
        static void Main()
        {
            int numbersCount = int.Parse(Console.ReadLine());
            int[] numbers = new int[numbersCount];
            for (int i = 0; i < numbersCount; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Array.Reverse(numbers);
            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
