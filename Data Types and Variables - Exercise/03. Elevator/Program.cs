using System;

namespace _03._Elevator
{
    internal class Program
    {
        static void Main()
        {
            int people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            double courses = (double)people / capacity;
            
            Console.WriteLine(Math.Ceiling(courses));
        }
    }
}
