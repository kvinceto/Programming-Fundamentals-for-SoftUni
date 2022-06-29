using System;

namespace _11._Refactor_Volume_of_Pyramid
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Length: ");
            double lenght = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double V = double.Parse(Console.ReadLine());
            V = (lenght * width * V) / 3;
            Console.WriteLine($"Pyramid Volume: {V:f2}");

        }
    }
}
