using System;

namespace _05._Digits__Letters_and_Other
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string digits = String.Empty;
            string letters = String.Empty;
            string otherChars = String.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];

                if (Char.IsDigit(currentChar))
                {
                    digits += currentChar;
                }
                else if (Char.IsLetter(currentChar))
                {
                    letters += currentChar;
                }
                else
                {
                    otherChars += currentChar;
                }
            }

            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(otherChars);
        }
    }
}
