using System;

namespace _04._Back_In_30_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            minutes += 30;
            if (minutes > 59)
            {
                minutes -= 60;
                hour++;
            }
            if (hour > 23)
            {
                hour -= 24;
            }
            if (minutes < 10)
            {
                Console.WriteLine($"{hour}:{minutes:d2}");
            }
            else
            {
                Console.WriteLine($"{hour}:{minutes}");
            }
        }
    }
}