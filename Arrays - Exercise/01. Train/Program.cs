using System;
using System.Linq;
using System.Xml;

namespace _01._Train
{
    internal class Program
    {
        static void Main()
        {
            int[] wagons = new int[int.Parse(Console.ReadLine())];
            int sum = 0;
            for (int i = 0; i < wagons.Length; i++)
            {
                wagons[i] = int.Parse(Console.ReadLine());
                sum = wagons.Sum();
            }

            Console.WriteLine(string.Join(' ', wagons));
            Console.WriteLine(sum);
        }
    }
}
