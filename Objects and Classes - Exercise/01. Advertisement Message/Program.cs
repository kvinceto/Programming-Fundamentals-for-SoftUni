using System;
using System.Collections.Generic;

namespace _01._Advertisement_Message
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfPhrases = new List<string>()
            {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product."
            };
            List<string> listOfEvents = new List<string>()
            {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };
            List<string> listOfAuthors = new List<string>()
                { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

            List<string> listOfCities = new List<string>() { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            int numberOfMessages = int.Parse(Console.ReadLine());
            Random random = new Random();
            for (int i = 0; i < numberOfMessages; i++)
            {
               string phrase = listOfPhrases[random.Next(0, listOfPhrases.Count)];
               string currentEvent = listOfEvents[random.Next(0,listOfEvents.Count)];
               string author = listOfAuthors[random.Next(0, listOfAuthors.Count)];
               string city = listOfCities[random.Next(0, listOfCities.Count)];

               Console.WriteLine($"{phrase} {currentEvent} {author} – {city}.");

            }
        }
    }
}
