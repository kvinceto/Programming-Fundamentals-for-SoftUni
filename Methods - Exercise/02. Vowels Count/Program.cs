using System;

namespace _02._Vowels_Count
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine().ToLower();
            int numberOfVowels = NumberOfVowels(input);
            Console.WriteLine(numberOfVowels);
        }

        private static int NumberOfVowels(string input)
        {
            int counter = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'a' || input[i] == 'o' || input[i] == 'u' || input[i] == 'e' ||
                    input[i] == 'y' || input[i] == 'i')
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
