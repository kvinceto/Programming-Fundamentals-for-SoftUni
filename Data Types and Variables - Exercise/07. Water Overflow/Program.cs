using System;

namespace _07._Water_Overflow
{
    internal class Program
    {
        static void Main()
        {
            int numberOfTimesToPourWater = int.Parse(Console.ReadLine());
            const int CAPACITY = 255;
            int litersInTheThank = 0;

            for (int i = 1; i <= numberOfTimesToPourWater; i++)
            {
                int litersToAdd = int.Parse(Console.ReadLine());
                if (CAPACITY - litersInTheThank >= litersToAdd)
                {
                    litersInTheThank += litersToAdd;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }

            Console.WriteLine(litersInTheThank);
        }
    }
}
