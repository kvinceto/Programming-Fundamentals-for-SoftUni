using System;
using System.Collections.Generic;
using System.Linq;

class Plant
{
    public string Name { get; set; }
    public string Rarity { get; set; }
    public List<double> Rating { get; set; }

    public Plant(string name, string rarity)
    {
        this.Name = name;
        this.Rarity = rarity;
        this.Rating = new List<double>();
    }
}

class Program
{
    static void Main()
    {
        List<Plant> plants = new List<Plant>();
        ReadInitialPlantEntries(plants);
        string input;
        while ((input = Console.ReadLine()) != "Exhibition")
        {
            string[] cmd = input.Split(new string[] { ": ", " - " }, StringSplitOptions.None);
            if (!plants.Any(x => x.Name == cmd[1]))
            {
                Console.WriteLine("error");
                continue;
            }
            Plant currentPlant = plants.Find(x => x.Name == cmd[1]);
            switch (cmd[0])
            {
                case "Rate":
                    currentPlant.Rating.Add(double.Parse(cmd[2])); break;
                case "Update":
                    currentPlant.Rarity = cmd[2]; break;
                case "Reset":
                    currentPlant.Rating.Clear(); break;
            }
        }
        Console.WriteLine("Plants for the exhibition:");
        foreach (Plant plant in plants)
        {
            double rating = plant.Rating.Count > 0 ? plant.Rating.Average() : 0;
            Console.WriteLine($"- {plant.Name}; Rarity: {plant.Rarity}; Rating: {rating:f2}");
        }
    }

    private static void ReadInitialPlantEntries(List<Plant> plants)
    {
        int numberOfEntries = int.Parse(Console.ReadLine());
        for (int i = 0; i < numberOfEntries; i++)
        {
            string[] input = Console.ReadLine().Split("<->");
            string plantName = input[0];
            string plantRarity = input[1];

            if (plants.Any(x => x.Name == plantName))
            {
                Plant plantToUpdate = plants.Find(x => x.Name == plantName);
                plantToUpdate.Rarity = plantRarity;
            }
            else
                plants.Add(new Plant(plantName, plantRarity));
        }
    }
}