using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Songs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfSongs = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();

            for (int i = 1; i <= numberOfSongs; i++)
            {
                string[] input = Console.ReadLine().Split('_').ToArray();
                Song song = new Song(input[0], input[1], input[2]);
                songs.Add(song);
            }

            string command = Console.ReadLine();
            if (command == "all")
            {
                foreach (var song in songs)
                {
                    Console.WriteLine(song.Name);   
                }
            }
            else
            {
                foreach (Song song in songs)
                {
                    if (song.TypeList == command)
                    {
                        Console.WriteLine(song.Name);   
                    }
                }
            }
        }
    }

    class Song
    {
        public Song(string type, string name, string time)
        {
            this.TypeList = type;
            this.Name = name;
            this.Time = time;
        }
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }
}
