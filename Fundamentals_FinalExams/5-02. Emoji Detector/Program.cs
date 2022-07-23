using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text.RegularExpressions;

namespace _5_02._Emoji_Detector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<emoji>::[A-Z][a-z]{2,}::)|(?<emoji>\*\*[A-Z][a-z]{2,}\*\*)";
            string thresholdPattern = @"\d";

            string input = Console.ReadLine();
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);

            Regex coolRegex = new Regex(thresholdPattern);
            MatchCollection ints = coolRegex.Matches(input);

            ulong coolThreshold = 1;
            foreach (Match number in ints)
            {
                coolThreshold *= ulong.Parse(number.ToString());
            }
            Console.WriteLine($"Cool threshold: {coolThreshold}");
            Console.WriteLine($"{matches.Count} emojis found in the text. The cool ones are:");

            Dictionary<string, ulong> emojies = new Dictionary<string, ulong>();
            foreach (Match match in matches)
            {
                string emoji = match.Groups["emoji"].ToString();
                ulong coolness = 0;
                foreach (char letter in emoji)
                {
                    if (Char.IsLetter(letter))
                    {
                        coolness += (ulong)letter;
                    }
                }

                if (coolness >= coolThreshold)
                {
                    emojies.Add(emoji, coolness);
                }
            }

            foreach (var emoji in emojies)
            {
                Console.WriteLine(emoji.Key);
            }
        }
    }
}
