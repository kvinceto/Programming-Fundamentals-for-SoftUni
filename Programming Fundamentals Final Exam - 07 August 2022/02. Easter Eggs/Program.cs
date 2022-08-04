using System;
using System.Text.RegularExpressions;

namespace _02._Easter_Eggs
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string input = Console.ReadLine();
           string pattern = @"(\@|\#)+(?<color>[a-z]{3,})(\@|\#)+[\W+]*[/]+(?<amount>[0-9]+)[/]+";

           MatchCollection matches = Regex.Matches(input, pattern);

           foreach (Match match in matches)
           {
               string color = match.Groups["color"].Value;
               int amount = int.Parse(match.Groups["amount"].Value);
               Console.WriteLine($"You found {amount} {color} eggs!");
           }
        }
    }
}
