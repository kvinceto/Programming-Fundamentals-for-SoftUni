﻿using System;
using System.Text.RegularExpressions;

namespace _03._Match_Dates
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string input = Console.ReadLine();

           string pattern = @"\b(?<day>[0-9]{2})(?<separator>[\./-])(?<month>[A-Z][a-z]{2})\k<separator>(?<year>[0-9]{4})";

           Regex regex = new Regex(pattern);
           MatchCollection matches = regex.Matches(input);
           foreach (Match match in matches)
           {
               Console.WriteLine($"Day: {match.Groups["day"]}, Month: {match.Groups["month"]}, Year: {match.Groups["year"]}");
           }
        }
    }
}
