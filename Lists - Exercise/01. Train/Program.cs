using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> train = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToList();
            int maxCapacity = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] command = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                int peopleToBeAdded = 0;
                int addPeople = 0;
                if (command.Length == 2)
                {
                    addPeople = int.Parse(command[1]);
                    AddPeople(train, addPeople);
                }
                else
                {
                    peopleToBeAdded = int.Parse(command[0]);
                    PeopleToBeAdded(train, peopleToBeAdded, maxCapacity);
                }
                input = Console.ReadLine();
            }

            Console.WriteLine(String.Join(' ', train));
        }

        private static void AddPeople(List<int> train, int addPeople)
        {
            train.Add(addPeople);
        }

        private static void PeopleToBeAdded(List<int> train, int peopleToBeAdded, int maxCapacity)
        {
            for (int i = 0; i < train.Count; i++)
            {
                if (train[i] + peopleToBeAdded <= maxCapacity )
                {
                    train[i] += peopleToBeAdded;
                    break;
                }
                else
                {
                    continue;
                }
            }
        }
    }
}
