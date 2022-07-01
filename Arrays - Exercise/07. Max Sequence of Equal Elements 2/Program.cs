using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements_2
{
    internal class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int currentNumber = 0;
            int lastNumber = int.MinValue;
            int counterOfSequence = 0;
            int maxCounter = 0;
            int sequenceNumber = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                currentNumber = numbers[i];
                if (currentNumber == lastNumber)
                {
                    counterOfSequence++;
                }
                else
                {
                    counterOfSequence = 1;
                }

                if (counterOfSequence > maxCounter)
                {
                    maxCounter = counterOfSequence;
                    sequenceNumber = currentNumber;
                }

                lastNumber = currentNumber;
            }

            for (int i = 0; i < maxCounter; i++)
            {
                Console.Write($"{sequenceNumber} ");   
            }
        }
    }
}
