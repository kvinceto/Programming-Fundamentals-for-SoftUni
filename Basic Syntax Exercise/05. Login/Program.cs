using System;

namespace _05._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string user = Console.ReadLine();
            char[] charArray = user.ToCharArray();
            Array.Reverse(charArray);
            string password = Console.ReadLine();
            string pass = new string(charArray);
            int counter = 0;

            while (password != pass)
            {
                counter++;
                if (counter == 4)
                {
                    Console.WriteLine($"User {user} blocked!");
                    return;
                }
                Console.WriteLine("Incorrect password. Try again.");

                password = Console.ReadLine();
            }
            Console.WriteLine($"User {user} logged in.");
        }
    }
}