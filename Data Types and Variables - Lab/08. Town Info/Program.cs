﻿using System;

namespace _08._Town_Info
{
    internal class Program
    {
        static void Main()
        {
            string townName = Console.ReadLine();
            int population = int.Parse(Console.ReadLine());
            double area = double.Parse(Console.ReadLine());
            Console.WriteLine($"Town {townName} has population of {population} and area {area} square km.");
        }
    }
}
