using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _2_02._Destination_Mapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string places = Console.ReadLine();
            string pattern = @"=(?<place>[A-Z][A-Za-z]{2,})=|/(?<place>[A-Z][A-Za-z]{2,})/";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(places);
            List<string> destinations = new List<string>();
            int points = 0;
            foreach (Match match in matches)
            {
                string destination = match.Groups["place"].Value;
                destinations.Add(destination);
                points += destination.Length;
            }

            Console.WriteLine($"Destinations: {string.Join(", ", destinations)}");
            Console.WriteLine($"Travel Points: {points}");
        }
    }
}
