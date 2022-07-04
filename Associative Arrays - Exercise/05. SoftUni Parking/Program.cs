using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            Dictionary<string, string> listOfReigteredCars = new Dictionary<string, string>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "register")
                {
                    string user = command[1];
                    string licensePlate = command[2];
                    if (listOfReigteredCars.ContainsKey(user))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlate}");
                        continue;
                    }
                    else
                    {
                        listOfReigteredCars.Add(user, licensePlate);
                        Console.WriteLine($"{user} registered {licensePlate} successfully");
                    }
                }
                else if (command[0] == "unregister")
                {
                    string user = command[1];
                    if (listOfReigteredCars.ContainsKey(user))
                    {
                        listOfReigteredCars.Remove(user);
                        Console.WriteLine($"{user} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {user} not found");
                    }
                }
            }

            listOfReigteredCars.ToList().ForEach(car =>
                Console.WriteLine($"{car.Key} => {car.Value}"));
        }
    }
}
