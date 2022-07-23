using System;
using System.Text;

namespace _4_01._Password_Reset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (true)
            {
                string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (command[0] == "Done")
                {
                    break;
                }

                switch (command[0])
                {
                    case "TakeOdd":
                        input = TakeOddCommand(input);
                        Console.WriteLine(input); break;
                    case "Cut":
                        input = CutCommand(input, command);
                        Console.WriteLine(input); break;
                    case "Substitute":
                       input = SubstituteCommand(input, command); break;
                }
            }

            Console.WriteLine($"Your password is: {input}");
        }

        private static string SubstituteCommand(string input, string[] command)
        {
            string substring = command[1];
            string newString = command[2];
            if (input.Contains(substring))
            {
                input = input.Replace(substring, newString);
                Console.WriteLine(input);
            }
            else
            {
                Console.WriteLine("Nothing to replace!");
            }

            return input;
        }

        private static string CutCommand(string input, string[] command)
        {
            int index = int.Parse(command[1]);
            int length = int.Parse(command[2]);
            input = input.Remove(index, length);
            return input;
        }

        private static string TakeOddCommand(string input)
        {
            StringBuilder output = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                if (i % 2 == 1)
                {
                    output.Append(input[i]);
                }
            }

            return output.ToString();
        }
    }
}
