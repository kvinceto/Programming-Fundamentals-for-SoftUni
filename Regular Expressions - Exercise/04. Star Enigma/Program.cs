using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _04._Star_Enigma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfMessages = int.Parse(Console.ReadLine());
            string patternForLettersCount = @"[sStTaArR]";
            Regex regexLetters = new Regex(patternForLettersCount);
            SortedDictionary<char, List<string>> planets = new SortedDictionary<char, List<string>>
            {
                ['A'] = new List<string>(),
                ['D'] = new List<string>()
            };

            for (int i = 0; i < numberOfMessages; i++)
            {
                string message = Console.ReadLine();
                MatchCollection lettersCollection = regexLetters.Matches(message);

                StringBuilder decryptedMessage = new StringBuilder();
                foreach (char letter in message)
                {
                    char newLetter = (char)((int)letter - lettersCollection.Count);
                    decryptedMessage.Append(newLetter);

                }
                string decryptedMsg = decryptedMessage.ToString();

                string patternForDecryption = @"@(?<name>[A-Za-z]+)[^@:!\->]*:(?<population>\d+)[^@:!\->]*!(?<type>[A|D])![^@:!\->]*->(?<count>\d+)";
                Regex decrypt = new Regex(patternForDecryption);
                Match matches = decrypt.Match(decryptedMsg);
                if (!matches.Success)
                {
                    continue;
                }

                string planetName = matches.Groups["name"].Value;
                int planetPopulation = int.Parse(matches.Groups["population"].Value);
                char attackType = char.Parse(matches.Groups["type"].Value);
                int soldierCount = int.Parse(matches.Groups["count"].Value);

                if (planets.ContainsKey(attackType))
                {
                    planets[attackType].Add(planetName);
                }

            }

            Console.WriteLine($"Attacked planets: {planets['A'].Count}");
            if (planets['A'].Count > 0)
            {
                foreach (string planet in planets['A'].OrderBy(p => p))
                {
                    Console.WriteLine($"-> {planet}");
                }
            }

            Console.WriteLine($"Destroyed planets: {planets['D'].Count}");
            if (planets['D'].Count > 0)
            {
                foreach (string planet in planets['D'].OrderBy(p => p))
                {
                    Console.WriteLine($"-> {planet}");
                }
            }
        }
    }
}