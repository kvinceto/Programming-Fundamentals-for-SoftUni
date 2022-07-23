using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _3_02._Mirror_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"(\@(?<firstWord>[A-Za-z]{3,})\@\@(?<secondWord>[A-Za-z]{3,})\@)|(\#(?<firstWord>[A-Za-z]{3,})\#\#(?<secondWord>[A-Za-z]{3,})\#)";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);
            if (matches.Count == 0)
            {
                Console.WriteLine("No word pairs found!");
            }
            else
            {
                Console.WriteLine($"{matches.Count} word pairs found!");
            }

            Dictionary<string, string> validWords = new Dictionary<string, string>();
            foreach (Match match in matches)
            {
                string firstWord = match.Groups["firstWord"].ToString();
                string secondWord = match.Groups["secondWord"].ToString();
                string reversedString = String.Empty;
                for (int i = secondWord.Length - 1; i >= 0; i--)
                {
                    reversedString += secondWord[i].ToString();
                }

                if (firstWord == reversedString)
                {
                    validWords.Add(firstWord, secondWord);
                }
            }

            if (validWords.Count > 0)
            {
                Console.WriteLine("The mirror words are:");
                List<string> output = new List<string>();
                foreach (var word in validWords)
                {
                    output.Add($"{word.Key} <=> {word.Value}");
                }

                Console.WriteLine(string.Join(", ", output));
            }
            else
            {
                Console.WriteLine("No mirror words!");
            }
        }
    }
}
