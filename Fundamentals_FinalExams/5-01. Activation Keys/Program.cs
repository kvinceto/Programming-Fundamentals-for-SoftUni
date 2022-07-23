using System;
using System.Text;

namespace _5_01._Activation_Keys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder key = new StringBuilder(Console.ReadLine());

            while (true)
            {
                string[] command = Console.ReadLine().Split(">>>", StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "Generate")
                {
                    break;
                }

                switch (command[0])
                {
                    case "Contains":
                        ContainsCommand(key, command); break;
                    case "Flip":
                        FlipCommand(key, command); break;
                    case "Slice":
                        SliceCommand(key, command); break;
                }
            }

            Console.WriteLine($"Your activation key is: {key.ToString()}");
        }

        private static void SliceCommand(StringBuilder key, string[] command)
        {
           int startIndex = int.Parse(command[1]);
           int endIndex = int.Parse(command[2]);
           key.Remove(startIndex, endIndex - startIndex);
           Console.WriteLine(key.ToString());
        }

        private static void FlipCommand(StringBuilder key, string[] command)
        {
            string caseType = command[1];
            int startIndex = int.Parse(command[2]);
            int endIndex = int.Parse(command[3]);
            string substring = key.ToString().Substring(startIndex, endIndex - startIndex);
            string changedSubstring = caseType == "Upper" ? substring.ToUpper() : substring.ToLower();
            key.Replace(substring, changedSubstring);
            Console.WriteLine(key.ToString());
        }

        private static void ContainsCommand(StringBuilder key, string[] command)
        {
            string substring = command[1];
            Console.WriteLine(key.ToString().Contains(substring)
                ? $"{key} contains {substring}"
                : "Substring not found!");
        }
    }
}
