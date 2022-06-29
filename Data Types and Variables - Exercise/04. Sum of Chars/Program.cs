using System;

namespace _04._Sum_of_Chars
{
    internal class Program
    {
        static void Main()
        {
            int charCount = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < charCount; i++)
            {
                char currentChar = char.Parse(Console.ReadLine());
                sum += (int)currentChar;
            }

            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
