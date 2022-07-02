using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Gauss__Trick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToList();
            List<int> newNumbers = new List<int>();
            while (numbers.Count > 1)
            {
                int newNumber = numbers[0] + numbers[numbers.Count - 1];
                numbers.RemoveAt(numbers.Count - 1);
                numbers.RemoveAt(0);
                newNumbers.Add(newNumber);
            }

            if (numbers.Count > 0)
            {
                newNumbers.Add(numbers[0]);
            }
            Console.WriteLine(string.Join(' ', newNumbers));
        }
    }
}