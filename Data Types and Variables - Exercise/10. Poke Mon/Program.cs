using System;

namespace _10._Poke_Mon
{
    internal class Program
    {
        static void Main()
        {
            int pokePower = int.Parse(Console.ReadLine());
            int startingPower = pokePower;
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            int counter = 0;

            while (pokePower >= distance)
            {
                pokePower -= distance;
                counter++;
                if (pokePower * 2 == startingPower && pokePower >= exhaustionFactor && exhaustionFactor != 0)
                {
                    pokePower /= exhaustionFactor;
                }

            }

            Console.WriteLine(pokePower);
            Console.WriteLine(counter);
        }
    }
}
