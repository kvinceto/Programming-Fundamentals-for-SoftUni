using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _02._Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> players = new Dictionary<string, int>();
            foreach (string name in names)
            {
                players.Add(name, 0);
            }

            string patternForNames = @"[A-Za-z]";
            string patternForDigits = @"[0-9]";

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end of race")
                {
                    break;
                }

                MatchCollection name = Regex.Matches(input, patternForNames);

                StringBuilder playerName = new StringBuilder();
                foreach (Match match in name)
                {
                    playerName.Append(match.Value);
                }

                if (players.ContainsKey(playerName.ToString()))
                {
                    MatchCollection digits = Regex.Matches(input, patternForDigits);
                    int sum = 0;
                    foreach (Match match in digits)
                    {
                        sum += int.Parse(match.Value);
                    }

                    players[playerName.ToString()] += sum;
                }
            }

            int counter = 0;
            foreach (var player in players.OrderByDescending(p => p.Value))
            {
                counter++;
                if (counter == 1)
                {
                    Console.WriteLine($"1st place: {player.Key}");
                }
                else if (counter == 2)
                {
                    Console.WriteLine($"2nd place: {player.Key}");
                }
                else if (counter == 3)
                {
                    Console.WriteLine($"3rd place: {player.Key}");
                }
                else
                {
                    break;
                }
            }

        }
    }
}
