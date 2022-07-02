using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace _03._House_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            List<string> guests = new List<string>();

            for (int i = 1; i <= numberOfCommands; i++)
            {
                List<string> command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
                if (command.Count == 3)
                {
                    AddGuest(guests, command);
                }
                else if (command.Count == 4)
                {
                    RemoveGuest(guests, command);
                }
            }

            foreach (string name in guests)
            {
                Console.WriteLine(name);  
            }
        }

        private static void RemoveGuest(List<string> guests, List<string> command)
        {
            foreach (string guest in guests)
            {
                if (guest == command[0])
                {
                    guests.Remove(command[0]);
                    return;
                }
            }

            Console.WriteLine($"{command[0]} is not in the list!");
        }

        private static void AddGuest(List<string> guests, List<string> command)
        {
            foreach (string guest in guests)
            {
                if (guest == command[0])
                {
                    Console.WriteLine($"{command[0]} is already in the list!");
                    return;
                }
            }
            guests.Add(command[0]);
        }
    }
}
