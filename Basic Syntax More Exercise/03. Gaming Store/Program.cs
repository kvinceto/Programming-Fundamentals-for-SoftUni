using System;

namespace _03._Gaming_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double startingMoney = budget;
            double priceCurrentGame = 0;
            string gameName = Console.ReadLine();
            while (gameName != "Game Time")
            {
                switch (gameName)
                {
                    case "OutFall 4":
                        priceCurrentGame = 39.99;
                        break;
                    case "CS: OG":
                        priceCurrentGame = 15.99;
                        break;
                    case "Zplinter Zell":
                        priceCurrentGame = 19.99;
                        break;
                    case "Honored 2":
                        priceCurrentGame = 59.99;
                        break;
                    case "RoverWatch":
                        priceCurrentGame = 29.99;
                        break;
                    case "RoverWatch Origins Edition":
                        priceCurrentGame = 39.99;
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        gameName = Console.ReadLine();
                        continue;
                }
                if (budget < priceCurrentGame)
                {
                    Console.WriteLine("Too Expensive");
                    gameName = Console.ReadLine();
                    continue;
                }
                else
                {
                    budget -= priceCurrentGame;
                    Console.WriteLine($"Bought {gameName}");
                    gameName = Console.ReadLine();
                }
                if (budget == 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }
            }
            Console.WriteLine($"Total spent: ${startingMoney - budget:f2}. Remaining: ${budget:f2}");
        }
    }
}
