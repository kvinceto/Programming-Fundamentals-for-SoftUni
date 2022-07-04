using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<char, int> chars = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != ' ')
                {
                    if (chars.ContainsKey(input[i]))
                    {
                        chars[input[i]]++;
                    }
                    else
                    {
                        chars.Add(input[i], 1);
                    }
                }
                else
                {
                    continue;
                }
            }

            chars.OrderByDescending(c => c.Value);

            foreach (var c in chars)
            {
                Console.WriteLine($"{c.Key} -> {c.Value}");
            }
        }
    }
}
