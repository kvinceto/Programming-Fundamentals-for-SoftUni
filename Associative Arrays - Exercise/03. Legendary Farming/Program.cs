using System;
using System.Collections.Generic;
using System.Threading.Channels;

namespace _03._Legendary_Farming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> keyMaterials = new Dictionary<string, int>();
            Dictionary<string, int> junkMaterial = new Dictionary<string, int>();

            while (true)
            {
                string[] input = Console.ReadLine().ToLower().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                bool isObtained = false;
                for (int i = 1; i < input.Length; i += 2)
                {
                    string material = input[i];
                    int quantity = int.Parse(input[i - 1]);

                    if (material == "shards" || material == "motes" || material == "fragments")
                    {
                        if (keyMaterials.ContainsKey(material))
                        {
                            keyMaterials[material] += quantity;
                        }
                        else
                        {
                            keyMaterials.Add(material, quantity);
                        }

                        if (keyMaterials[material] >= 250)
                        {
                            keyMaterials[material] -= 250;
                            Console.WriteLine(WriteObtainedItem(material));
                            isObtained = true;
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else
                    {
                        if (junkMaterial.ContainsKey(material))
                        {
                            junkMaterial[material] += quantity;
                        }
                        else
                        {
                            junkMaterial.Add(material, quantity);
                        }
                    }
                }

                if (isObtained)
                {
                    break;
                }
            }

            foreach (var material in keyMaterials)
            {
                Console.WriteLine($"{material.Key}: {material.Value}");
            }

            foreach (var material in junkMaterial)
            {
                Console.WriteLine($"{material.Key}: {material.Value}");
            }
        }

        private static string WriteObtainedItem(string material)
        {
            switch (material)
            {
                case "shards":
                    return "Shadowmourne obtained!";
                case "motes":
                    return "Dragonwrath obtained!";
                case "fragments":
                    return "Valanyr obtained!";
                default:
                    return null;
            }
        }
    }
}