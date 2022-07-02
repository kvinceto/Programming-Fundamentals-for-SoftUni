using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToList();
            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] commandToArray = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (commandToArray[0] == "Add")
                {
                    numbers.Add(int.Parse(commandToArray[1]));
                }
                else if (commandToArray[0] == "Remove")
                {
                    numbers.Remove(int.Parse(commandToArray[1]));
                }
                else if(commandToArray[0] == "RemoveAt")
                {
                    numbers.RemoveAt(int.Parse(commandToArray[1]));
                }
                else if(commandToArray[0] == "Insert")
                {
                    numbers.Insert(int.Parse(commandToArray[2]), int.Parse(commandToArray[1]));
                }
                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
