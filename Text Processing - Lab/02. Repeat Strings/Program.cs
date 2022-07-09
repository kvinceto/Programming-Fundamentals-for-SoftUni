using System;

namespace _02._Repeat_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputStrings = Console.ReadLine().Split(' ');

            string newString = String.Empty;

            foreach (var word in inputStrings)
            {
                for (int i = 1; i <= word.Length; i++)
                {
                    newString += word;
                }
            }

            Console.WriteLine(newString);
        }
    }
}
