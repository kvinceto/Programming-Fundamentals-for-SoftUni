using System;
using System.Collections.Generic;

namespace _5_03._P_rates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, City> cities = new Dictionary<string, City>();
            while (true)
            {
                string[] city = Console.ReadLine().Split("||", StringSplitOptions.RemoveEmptyEntries);
                if (city[0] == "Sail")
                {
                    break;
                }

                string name = city[0];
                int population = int.Parse(city[1]);
                int gold = int.Parse(city[2]);

                if (!cities.ContainsKey(name))
                {
                    cities.Add(name, new City(population, gold));
                    continue;
                }

                cities[name].Population += population;
                cities[name].Gold += gold;
            }

            while (true)
            {
                string[] command = Console.ReadLine().Split("=>", StringSplitOptions.RemoveEmptyEntries);
                if (command[0] == "End")
                {
                    break;
                }

                switch (command[0])
                {
                    case "Plunder":
                        PlunderCommand(command, cities); break;
                    case "Prosper":
                        ProsperCommand(command, cities); break;
                }
            }

            if (cities.Count == 0)
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
            else
            {
                Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");
                foreach (var city in cities)
                {
                    Console.WriteLine($"{city.Key} -> Population: {city.Value.Population} citizens, Gold: {city.Value.Gold} kg");
                }
            }
        }

        private static void ProsperCommand(string[] command, Dictionary<string, City> cities)
        {
            string town = command[1];
            int gold = int.Parse(command[2]);
            if (gold >= 0)
            {
                cities[town].Gold += gold;
                Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {cities[town].Gold} gold.");
            }
            else
            {
                Console.WriteLine("Gold added cannot be a negative number!");
            }

        }

        private static void PlunderCommand(string[] command, Dictionary<string, City> cities)
        {
            string town = command[1];
            int people = int.Parse(command[2]);
            int gold = int.Parse(command[3]);
            cities[town].Population -= people;
            cities[town].Gold -= gold;
            if (cities[town].Population == 0 || cities[town].Gold == 0)
            {
                cities.Remove(town);
                Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");
                Console.WriteLine($"{town} has been wiped off the map!");
            }
            else
            {
                Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");
            }
        }
    }

    class City
    {
        public City(int population, int gold)
        {
            Population = population;
            Gold = gold;
        }
        public int Population { get; set; }
        public int Gold { get; set; }
    }
}
