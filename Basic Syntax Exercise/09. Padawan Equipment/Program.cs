using System;

namespace _09._Padawan_Equipment
{
    internal class Program
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            double lightsaberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            double lightsabersCount = Math.Ceiling(studentsCount * 1.10);
            double lightsabersSum = lightsaberPrice * lightsabersCount;
            double robeSum = robePrice * studentsCount;
            double beltCount = studentsCount - Math.Floor(studentsCount / 6.0);
            double beltSum = beltCount * beltPrice;
            double expences = lightsabersSum + robeSum + beltSum;
            if (budget >= expences)
            {
                Console.WriteLine($"The money is enough - it would cost {expences:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {Math.Abs(budget - expences):f2}lv more.");
            }
        }
    }
}