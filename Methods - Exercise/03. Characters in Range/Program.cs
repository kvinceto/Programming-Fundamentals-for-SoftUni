using System;

namespace _03._Characters_in_Range
{
    internal class Program
    {
        static void Main()
        {
            char firstChar = char.Parse(Console.ReadLine());
            char lastChar = char.Parse(Console.ReadLine());
            string charsInRange = Characters_in_Range(firstChar, lastChar);
            Console.WriteLine(charsInRange);
        }

        private static string Characters_in_Range(char firstChar, char lastChar)
        {
            string charsInRange = String.Empty;
            int ascciOfFirstChar = (int)firstChar;
            int ascciOfLastChar = (int)lastChar;
            if (ascciOfLastChar >= ascciOfFirstChar)
            {

                for (int i = ascciOfFirstChar + 1; i < ascciOfLastChar; i++)
                {
                    char currentCharacter = (char)i;
                    charsInRange += $"{currentCharacter} ";
                }
            }
            else
            {
                for (int i = ascciOfLastChar + 1; i < ascciOfFirstChar; i++)
                {
                    char currentCharacter = (char)i;
                    charsInRange += $"{currentCharacter} ";
                }
            }
            return charsInRange;
        }
    }
}
