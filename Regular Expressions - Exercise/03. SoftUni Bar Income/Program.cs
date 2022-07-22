using System;
using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string validator = @"(?<customer>%[A-Z][a-z]+%).*?(?<product><\w+>).*?(?<count>\|[0-9]+\|).*?(?<price>[0-9]+[.]*[0-9]*\$)";

            double sum = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end of shift")
                {
                    break;
                }
                Regex regex = new Regex(validator);
                if (!Regex.IsMatch(input, validator))
                {
                    continue;
                }
                
                Match match = regex.Match(input);
                string customer = match.Groups["customer"].Value.Replace("%", "");
                string product = match.Groups["product"].Value.Replace("<", "").Replace(">", "");
                int count = int.Parse(match.Groups["count"].Value.Replace("|", ""));
                double price = double.Parse(match.Groups["price"].Value.Replace("$", ""));

                Console.WriteLine($"{customer}: {product} - {count * price:f2}");
                sum += count * price;
            }

            Console.WriteLine($"Total income: {sum:f2}");
        }
    }
}
