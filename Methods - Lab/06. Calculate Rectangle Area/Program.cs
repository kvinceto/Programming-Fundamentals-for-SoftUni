using System;

namespace _06._Calculate_Rectangle_Area
{
    internal class Program
    {
        static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = ArreaOfRectangle(width, height);
            Console.WriteLine(area);
        }

        private static double ArreaOfRectangle(double width, double height)
        {
            return width * height;
        }
    }
}
