using System;

namespace _07._Vending_Machine
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            double moneyAccumulated = 0;
            double price = 0;

            while (input != "Start")
            {
                double coin = double.Parse(input);
                if (coin == 0.1 || coin == 0.2 || coin == 0.5 || coin == 1 || coin == 2)
                {
                    moneyAccumulated += coin;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coin}");
                }
                input = Console.ReadLine();
            }
            input = Console.ReadLine();
            while (input != "End")
            {
                switch (input)
                {
                    case "Nuts":
                        price = 2;
                        break;
                    case "Water":
                        price = 0.7;
                        break;
                    case "Crisps":
                        price = 1.5;
                        break;
                    case "Soda":
                        price = 0.8;
                        break;
                    case "Coke":
                        price = 1;
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        input = Console.ReadLine();
                        continue;
                }
                if (moneyAccumulated >= price)
                {
                    moneyAccumulated -= price;
                    Console.WriteLine($"Purchased {input.ToLower()}");
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Change: {moneyAccumulated:f2}");
        }
    }
}
