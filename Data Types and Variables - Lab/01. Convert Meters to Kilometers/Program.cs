using System;

namespace _01._Convert_Meters_to_Kilometers
{
    internal class Program
    {
        static void Main()
        {
            int meters = int.Parse(Console.ReadLine());
            decimal km = (decimal)(meters * 0.001);
            Console.WriteLine($"{km:f2}");
        }
    }
}
