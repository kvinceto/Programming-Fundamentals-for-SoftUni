using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Text_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> bannedWords = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            string input = Console.ReadLine();

            foreach (string word in bannedWords)
            {
                string newWord = String.Empty;
                for (int i = 0; i < word.Length; i++)
                {
                    newWord += '*';
                }
                while (input.Contains(word))
                {
                    input = input.Replace(word, newWord);
                }
            }

            Console.WriteLine(input);
        }
    }
}
