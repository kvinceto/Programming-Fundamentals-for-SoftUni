using System;

namespace _02._Pounds_to_Dollars
{
    internal class Program
    {
        static void Main()
        {
            double pounds = double.Parse(Console.ReadLine());
            var usd = (decimal)(1.31 * pounds);
            Console.WriteLine($"{usd:f3}");
        }
    }
}
