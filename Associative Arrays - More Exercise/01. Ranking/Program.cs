using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace _01._Ranking
{
    internal class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(':');
            List<string> listOfContests = new List<string>();

            while (input[0] != "end of contests")
            {
                string contest = input[0] + "=>" + input[1];
                listOfContests.Add(contest);

                input = Console.ReadLine().Split(':');
            }
            SortedDictionary<string, Dictionary<string, int>> listOfUsers = new SortedDictionary<string, Dictionary<string, int>>();

            string[] inputUserData = Console.ReadLine().Split("=>");

            while (inputUserData[0] != "end of submissions")
            {
                string contestCheck = inputUserData[0] + "=>" + inputUserData[1];

                if (listOfContests.Contains(contestCheck.ToString()))
                {
                    string currentContest = inputUserData[0];
                    string username = inputUserData[2];
                    int usersPointsForCurrentContest = int.Parse(inputUserData[3]);

                    if (listOfUsers.ContainsKey(username))
                    {
                        if (listOfUsers[username].ContainsKey(currentContest))
                        {
                            listOfUsers[username][currentContest] = Math.Max(usersPointsForCurrentContest, listOfUsers[username][currentContest]);
                        }
                        else
                        {
                            listOfUsers[username].Add(currentContest, usersPointsForCurrentContest);
                        }
                    }
                    else
                    {
                        listOfUsers.Add(username, new Dictionary<string, int>());
                        listOfUsers[username].Add(currentContest, usersPointsForCurrentContest);
                    }

                }

                inputUserData = Console.ReadLine().Split("=>");
            }

            SortedDictionary<string, int> topUser = new SortedDictionary<string, int>();

            foreach (var user in listOfUsers)
            {
                int sumOfCurrentUserPoints = listOfUsers[user.Key].Values.Sum();

                topUser.Add(user.Key, sumOfCurrentUserPoints);
            }

            var sortedTopUser = topUser.OrderByDescending(x => x.Value);
            Console.WriteLine($"Best candidate is {sortedTopUser.First().Key} with total {sortedTopUser.First().Value} points.");
            Console.WriteLine("Ranking:");

            foreach (var user in listOfUsers)
            {
                Console.WriteLine(user.Key);
                foreach (var course in user.Value.OrderByDescending(x=> x.Value))
                {
                    Console.WriteLine($"#  {course.Key} -> {course.Value}");
                }
            }
        }
    }
}
