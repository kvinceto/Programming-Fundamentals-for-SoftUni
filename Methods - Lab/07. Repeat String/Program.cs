using System;

namespace _07._Repeat_String
{
    internal class Program
    {
        static void Main()
        {
            string stringInput = Console.ReadLine();
            int numberOfRepeats = int.Parse(Console.ReadLine());
            Console.WriteLine(
            PrintNewString(stringInput, numberOfRepeats));
        }

        private static string PrintNewString(string stringInput, int numberOfRepeats)
        {
            string result = String.Empty;
            for (int i = 1; i <= numberOfRepeats; i++)
            {
                result += stringInput;
            }

            return result;
        }

    }
}
