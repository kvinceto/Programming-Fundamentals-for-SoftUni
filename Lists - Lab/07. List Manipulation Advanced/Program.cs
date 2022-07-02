using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _07._List_Manipulation_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToList();
            string command = Console.ReadLine();
            bool isChanged = false;
            while (command != "end")
            {
                string[] commandToArray = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (commandToArray[0] == "Add")
                {
                    numbers.Add(int.Parse(commandToArray[1]));
                    isChanged = true;
                }
                else if (commandToArray[0] == "Remove")
                {
                    numbers.Remove(int.Parse(commandToArray[1]));
                    isChanged = true;
                }
                else if (commandToArray[0] == "RemoveAt")
                {
                    numbers.RemoveAt(int.Parse(commandToArray[1]));
                    isChanged = true;
                }
                else if (commandToArray[0] == "Insert")
                {
                    numbers.Insert(int.Parse(commandToArray[2]), int.Parse(commandToArray[1]));
                    isChanged = true;
                }
                else if (commandToArray[0] == "Contains")
                {
                    bool isInTheList = false;
                    foreach (int number in numbers)
                    {
                        if (number == int.Parse(commandToArray[1]))
                        {
                            Console.WriteLine("Yes");
                            isInTheList = true;
                            break;
                        }
                    }

                    if (isInTheList)
                    {
                        command = Console.ReadLine();
                        continue;
                    } 
                    Console.WriteLine("No such number");
                }
                else if (commandToArray[0] == "PrintEven")
                {
                    List<int> evenNumbers = new List<int>();
                    foreach (int number in numbers)
                    {
                        if (number % 2 == 0)
                        {
                            evenNumbers.Add(number);
                        }
                    }

                    if (evenNumbers.Count > 0)
                    {
                        Console.WriteLine(string.Join(' ', evenNumbers));
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (commandToArray[0] == "PrintOdd")
                {
                    List<int> oddNumbers = new List<int>();
                    foreach (int number in numbers)
                    {
                        if (number % 2 != 0)
                        {
                            oddNumbers.Add(number);
                        }
                    }

                    if (oddNumbers.Count > 0)
                    {
                        Console.WriteLine(string.Join(' ', oddNumbers));
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (commandToArray[0] == "GetSum")
                {
                    int sumOfNumbers = numbers.Sum();
                    Console.WriteLine(sumOfNumbers);
                }
                else if (commandToArray[0] == "Filter")
                {
                    FilterNumbers(commandToArray, numbers);
                }
                command = Console.ReadLine();
            }

            if (isChanged)
            {
                Console.WriteLine(string.Join(' ', numbers));
            }
        }

        private static void FilterNumbers(string[] commandToArray, List<int> numbers)
        {
            int numberToCompareTo = int.Parse(commandToArray[2]);
            List<int> currentNumbers = new List<int>();
            switch (commandToArray[1])
            {
                case ">":
                    foreach (int number in numbers)
                    {
                        if (number > numberToCompareTo)
                        {
                            currentNumbers.Add(number);
                        }
                    }
                    break;
                case "<":
                    foreach (int number in numbers)
                    {
                        if (number < numberToCompareTo)
                        {
                            currentNumbers.Add(number);
                        }
                    }
                    break;
                case ">=":
                    foreach (int number in numbers)
                    {
                        if (number >= numberToCompareTo)
                        {
                            currentNumbers.Add(number);
                        }
                    }
                    break;
                case "<=":
                    foreach (int number in numbers)
                    {
                        if (number <= numberToCompareTo)
                        {
                            currentNumbers.Add(number);
                        }
                    }
                    break;
            }

            Console.WriteLine(string.Join(' ', currentNumbers));
        }
    }
}
