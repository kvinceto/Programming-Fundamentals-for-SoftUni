using System;
using System.Text;

namespace _3_01._Secret_Chat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder text = new StringBuilder(Console.ReadLine());

            while (true)
            {
                string[] command = Console.ReadLine().Split(":|:", StringSplitOptions.RemoveEmptyEntries);
                if (command[0] == "Reveal")
                {
                    break;
                }

                switch (command[0])
                {
                    case "InsertSpace":
                        InsertCommand(text, command); break;
                    case "Reverse":
                        ReverseCommand(text, command); break;
                    case "ChangeAll":
                        ChangeCommand(text, command); break;
                }
            }

            Console.WriteLine($"You have a new text message: {text.ToString()}");
        }

        private static void ChangeCommand(StringBuilder text, string[] command)
        {
            string substring = command[1];
            string replacement = command[2];
            text.Replace(substring, replacement);
            Console.WriteLine(text.ToString());
        }

        private static void ReverseCommand(StringBuilder text, string[] command)
        {
            string substring = command[1];
            if (text.ToString().Contains(substring))
            {
                text.Remove(text.ToString().IndexOf(substring), substring.Length);
                StringBuilder newString = new StringBuilder();
                for (int i = substring.Length - 1; i >= 0; i--)
                {
                    newString.Append(substring[i]);
                }
                text.Append(newString);
                Console.WriteLine(text.ToString());

            }
            else
            {
                Console.WriteLine("error");
            }
        }

        private static void InsertCommand(StringBuilder text, string[] command)
        {
            int index = int.Parse(command[1]);
            text.Insert(index, " ");
            Console.WriteLine(text.ToString());

        }
    }
}
