using System;
using System.Collections.Generic;
namespace _03._Messages_Manager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            Dictionary<string, User> users = new Dictionary<string, User>();

            while (true)
            {
                string[] command = Console.ReadLine().Split('=', StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "Statistics")
                {
                    break;
                }

                switch (command[0])
                {
                    case "Add":
                        AddCommand(users, command);
                        break;
                    case "Message":
                        MessageCommand(users, command, capacity);
                        break;
                    case "Empty":
                        EmptyCommand(users, command);
                        break;
                }
            }

            Console.WriteLine($"Users count: {users.Count}");
            foreach (var user in users)
            {
                Console.WriteLine($"{user.Key} - {user.Value.Sent + user.Value.Received}");
            }
        }



        private static void AddCommand(Dictionary<string, User> users, string[] command)
        {
            string username = command[1];
            if (!users.ContainsKey(username))
            {
                users.Add(username, new User(int.Parse(command[2]), int.Parse(command[3])));
            }
        }

        private static void MessageCommand(Dictionary<string, User> users, string[] command, int capacity)
        {
            string sender = command[1];
            string receiver = command[2];

            if (users.ContainsKey(sender) && users.ContainsKey(receiver))
            {
                users[sender].Sent++;
                users[receiver].Received++;

                if (users[sender].Sent + users[sender].Received == capacity)
                {
                    Console.WriteLine($"{sender} reached the capacity!");
                    users.Remove(sender);
                }

                if (users[receiver].Received + users[receiver].Sent == capacity)
                {
                    Console.WriteLine($"{receiver} reached the capacity!");
                    users.Remove(receiver);
                }

            }
        }

        private static void EmptyCommand(Dictionary<string, User> users, string[] command)
        {
            string username = command[1];

            if (username == "All")
            {
                users.Clear();
            }

            if (users.ContainsKey(username))
            {
                users.Remove(username);
            }
        }
    }

    class User
    {
        public User(int sent, int received)
        {
            Sent = sent;
            Received = received;
        }
        public int Sent { get; set; }
        public int Received { get; set; }
    }
}
