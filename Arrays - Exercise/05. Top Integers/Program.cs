using System;
using System.Linq;

namespace _05._Top_Integers
{
    internal class Program
    {
        static void Main()
        {
            int[] arrayOfIntegers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < arrayOfIntegers.Length - 1; i++)
            {
                bool isGreater = true;
                int currentNumber = arrayOfIntegers[i];
                for (int j = i + 1; j < arrayOfIntegers.Length; j++)
                {

                    if (arrayOfIntegers[i] <= arrayOfIntegers[j])
                    {
                        isGreater = false;
                        break;
                    }

                }
                if (isGreater)
                {
                    Console.Write($"{currentNumber} ");
                }
            }

            Console.Write($"{arrayOfIntegers[arrayOfIntegers.Length - 1]} ");

        }
    }
}
