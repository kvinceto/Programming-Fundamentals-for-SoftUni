using System;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder stops = new StringBuilder(Console.ReadLine());
        string input;
        while ((input = Console.ReadLine()) != "Travel")
        {
            string[] cmd = input.Split(':');
            switch (cmd[0])
            {
                case "Add Stop":
                    AddStop(stops, cmd); break;
                case "Remove Stop":
                    RemoveStop(stops, cmd); break;
                case "Switch":
                    stops.Replace(cmd[1], cmd[2]); break;
            }
            Console.WriteLine(stops.ToString());
        }
        Console.WriteLine($"Ready for world tour! Planned stops: {stops}");
    }

    private static void AddStop(StringBuilder stops, string[] cmd)
    {
        int index = int.Parse(cmd[1]);
        string stringToInsert = cmd[2];
        if (index >= 0 && index < stops.Length)
            stops.Insert(index, stringToInsert);
    }

    private static void RemoveStop(StringBuilder stops, string[] cmd)
    {
        int startIndex = int.Parse(cmd[1]);
        int endIndex = int.Parse(cmd[2]);
        if (startIndex >= 0 && startIndex < stops.Length &&
            endIndex >= 0 && endIndex < stops.Length)
        {
            stops.Remove(startIndex, endIndex - startIndex + 1);
        }
    }
}