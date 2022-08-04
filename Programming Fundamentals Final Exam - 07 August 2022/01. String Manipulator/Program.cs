using System;

namespace _01._String_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (true)
            {
                string[] command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "End")
                {
                    break;
                }

                switch (command[0])
                {
                    case "Translate":
                        input = Translate(input, command);
                        break;
                    case "Includes":
                        Includes(input, command);
                        break;
                    case "Start":
                        StartCommand(input, command);
                        break;
                    case "Lowercase":
                        input = Lower(input, command);
                        break;
                    case "FindIndex":
                        FindCommand(input, command);
                        break;
                    case "Remove":
                        input = Remove(input, command);
                        break;
                }
            }
        }

        private static string Translate(string input, string[] command)
        {
            char ch = char.Parse(command[1]);
            char replacement = char.Parse(command[2]);
            input = input.Replace(ch, replacement);
            Console.WriteLine(input);
            return input;
        }

        private static void Includes(string input, string[] command)
        {
            string substring = command[1];
            if (input.Contains(substring))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }

        private static void StartCommand(string input, string[] command)
        {
            string substring = command[1];
            int length = substring.Length;
            string startingSubstring = input.Substring(0, length);
            if (substring == startingSubstring)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }

        private static string Lower(string input, string[] command)
        {
            input = input.ToLower();
            Console.WriteLine(input);
            return input;
        }

        private static void FindCommand(string input, string[] command)
        {
            char ch = char.Parse(command[1]);
            int place = input.LastIndexOf(ch);
            Console.WriteLine(place);
        }

        private static string Remove(string input, string[] command)
        {
            int startIndex = int.Parse(command[1]);
            int count = int.Parse(command[2]);
            input = input.Remove(startIndex, count);
            Console.WriteLine(input);
            return input;
        }
    }
}
