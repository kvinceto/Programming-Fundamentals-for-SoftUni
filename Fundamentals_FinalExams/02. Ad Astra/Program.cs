using System;
using System.Text.RegularExpressions;

namespace _02._Ad_Astra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int CALORIES_PER_DAY = 2000;
            string text = Console.ReadLine();
            string pattern = @"(?<separator>(\||\#))(?<name>[A-Za-z\s]+)\k<separator>(?<date>([0-9]{2}\/[0-9]{2}\/[0-9]{2}))\k<separator>(?<calories>([0-9]+))\k<separator>";
            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(text);

            int caloriesSum = 0;
            foreach (Match match in matches)
            {
                caloriesSum += int.Parse(match.Groups["calories"].Value);
            }

            int days = caloriesSum / CALORIES_PER_DAY;
            Console.WriteLine($"You have food to last you for: {days} days!");

            foreach (Match match in matches)
            {
                Console.WriteLine($"Item: {match.Groups["name"].Value}, Best before: {match.Groups["date"].Value}, Nutrition: {int.Parse(match.Groups["calories"].Value)}");
            }
        }
    }
}
