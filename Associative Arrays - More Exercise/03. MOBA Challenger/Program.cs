using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._MOBA_Challenger
{
    internal class Program
    {
        static void Main(string[] args)// ne pachata pravilno
        {
            Dictionary<string, Dictionary<string, int>> listOfPlayers = new Dictionary<string, Dictionary<string, int>>();

            string input = Console.ReadLine();

            while (input != "Season end")
            {
                bool isPlayer = input.Split(" -> ").ToArray().Length == 3 ? true : false;
                bool isDuel = input.Split(" vs ").ToArray().Length == 2 ? true : false;

                if (isPlayer)
                {
                    string[] data = input.Split(" -> ").ToArray();
                    string player = data[0];
                    string position = data[1];
                    int skill = int.Parse(data[2]);

                    if (listOfPlayers.ContainsKey(player))
                    {
                        if (listOfPlayers[player].ContainsKey(position))
                        {
                            if (listOfPlayers[player][position] < skill)
                            {
                                listOfPlayers[player][position] = skill;
                            }
                        }
                        else
                        {
                            listOfPlayers[player].Add(position, skill);
                        }
                    }
                    else
                    {
                        listOfPlayers.Add(player, new Dictionary<string, int>());
                        listOfPlayers[player].Add(position, skill);
                    }
                }
                else if (isDuel)
                {
                    string[] data = input.Split(" vs ").ToArray();
                    string firstPlayer = data[0];
                    string secondPlayer = data[1];

                    if (listOfPlayers.ContainsKey(firstPlayer) && listOfPlayers.ContainsKey(secondPlayer))
                    {
                        bool positionMatch = false;
                        foreach (var position in listOfPlayers[firstPlayer])
                        {
                            string currentPositionFirstPlayers = position.Key;
                            foreach (var pos in listOfPlayers[secondPlayer])
                            {
                                string player = pos.Key;
                                if (currentPositionFirstPlayers == player)
                                {
                                    positionMatch = true;
                                    break;
                                }
                            }
                            if (positionMatch)
                            {
                                break;
                            }
                        }

                        if (positionMatch)
                        {
                            int firstPlayerTotalPoints = listOfPlayers[firstPlayer].Values.Sum();
                            int secondPlayerTotalPoints = listOfPlayers[secondPlayer].Values.Sum();
                            if (firstPlayerTotalPoints > secondPlayerTotalPoints)
                            {
                                listOfPlayers.Remove(secondPlayer);
                            }
                            else if (secondPlayerTotalPoints > firstPlayerTotalPoints)
                            {
                                listOfPlayers.Remove(firstPlayer);
                            }
                        }
                    }
                }
                input = Console.ReadLine();
            }

            foreach (var player in listOfPlayers.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(n => n.Key))
            {
                Console.WriteLine($"{player.Key}: {player.Value.Values.Sum()} skill");
                foreach (var kvp in player.Value.OrderByDescending(p => p.Value).ThenBy(p => p.Key))
                {
                    Console.WriteLine($"- {kvp.Key} <::> {kvp.Value}");
                }
            }
        }
    }
}
