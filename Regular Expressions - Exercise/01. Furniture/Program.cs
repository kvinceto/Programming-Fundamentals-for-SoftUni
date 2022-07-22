using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @">>(?<name>[A-Z]*[a-z]*)<<(?<price>[\d\.]+)!(?<quantity>[0-9]+)";
            Regex regex = new Regex(pattern);
            List<Match> matches = new List<Match>();

            while (input != "Purchase")
            {
                if (regex.IsMatch(input))
                {
                    Match match = regex.Match(input);
                    matches.Add(match);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Bought furniture:");

            double sum = 0;
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Groups["name"]);
                sum += double.Parse(match.Groups["price"].ToString()) *
                       double.Parse(match.Groups["quantity"].ToString());
            }

            Console.WriteLine($"Total money spend: {sum:f2}");
        }
    }
}
