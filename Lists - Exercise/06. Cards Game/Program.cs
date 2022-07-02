using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Cards_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstPlayerHand = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();
            List<int> secondPlayerHand = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();

            while (firstPlayerHand.Count > 0 && secondPlayerHand.Count > 0)
            {
                int firstPlayerCard = firstPlayerHand[0];
                int secondPlayerCard = secondPlayerHand[0];
                if (firstPlayerCard > secondPlayerCard)
                {
                    firstPlayerHand.Add(firstPlayerCard);
                    firstPlayerHand.Add(secondPlayerCard);
                    firstPlayerHand.RemoveAt(0);
                    secondPlayerHand.RemoveAt(0);
                }
                else if (secondPlayerCard > firstPlayerCard)
                {
                    secondPlayerHand.Add(secondPlayerCard);
                    secondPlayerHand.Add(firstPlayerCard);
                    firstPlayerHand.RemoveAt(0);
                    secondPlayerHand.RemoveAt(0);
                }
                else if (firstPlayerCard == secondPlayerCard)
                {
                    firstPlayerHand.RemoveAt(0);
                    secondPlayerHand.RemoveAt(0);
                }
            }

            if (firstPlayerHand.Count > 0)
            {
                int sumOfList = firstPlayerHand.Sum();
                Console.WriteLine($"First player wins! Sum: {sumOfList}");
            }
            else if (secondPlayerHand.Count > 0)
            {
                int sumOfList = secondPlayerHand.Sum();
                Console.WriteLine($"Second player wins! Sum: {sumOfList}");
            }
        }
    }
}
