using System;
using System.Runtime.InteropServices.ComTypes;

namespace _06._Middle_Characters
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string output = CharsInTheMiddleOfString(input);
            Console.WriteLine(output);
        }

        private static string CharsInTheMiddleOfString(string input)
        {
            string output = String.Empty;

            if (input.Length % 2 == 0)
            {
                output += $"{input[input.Length / 2 - 1]}{input[input.Length / 2]}";
            }
            else
            {
                output += $"{input[input.Length / 2]}";
            }
            return output;
        }
    }
}
