using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToList();
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] command = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (command.Length == 2)
                {
                    int numberToBeRemoved = int.Parse(command[1]);
                    integers.RemoveAll(item => item== numberToBeRemoved);
                }
                else if (command.Length == 3)
                {
                    int numberToBeInserted = int.Parse(command[1]);
                    int indexToBeInsertedIn = int.Parse(command[2]);
                    integers.Insert(indexToBeInsertedIn, numberToBeInserted);
                }
                input = Console.ReadLine();
            }

            Console.WriteLine(String.Join(' ', integers));
        }
    }
}
