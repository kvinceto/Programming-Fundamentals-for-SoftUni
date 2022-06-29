using System;

namespace _09._Spice_Must_Flow
{
    internal class Program
    {
        static void Main()
        {
            int startingYield = int.Parse(Console.ReadLine());
            const int DECRIESING_RATE = 10;
            const int SPICE_CONSUMED_DAYLY = 26;
            int daysCounter = 0;
            int spicesInStorage = 0;

            while (startingYield >= 100)
            {
                spicesInStorage += startingYield - SPICE_CONSUMED_DAYLY;
                startingYield -= DECRIESING_RATE;
                daysCounter++;
            }

            if (spicesInStorage >= 26)
            {
                spicesInStorage -= SPICE_CONSUMED_DAYLY;
            }
            else
            {
                spicesInStorage = 0;
            }
            Console.WriteLine(daysCounter);
            Console.WriteLine(spicesInStorage);
        }
    }
}
