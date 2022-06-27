using System;

namespace _11._Orders
{
    internal class Program
    {
        static void Main()
        {
            int ordersCount = int.Parse(Console.ReadLine());
            double capsulePrice;
            int days;
            int capsulesCount;
            double orderPrice;
            double sum = 0;

            for (int currentOrder = 1; currentOrder <= ordersCount; currentOrder++)
            {
                capsulePrice = double.Parse(Console.ReadLine());
                days = int.Parse(Console.ReadLine());
                capsulesCount = int.Parse(Console.ReadLine());
                orderPrice = days * capsulesCount * capsulePrice;
                Console.WriteLine($"The price for the coffee is: ${orderPrice:f2}");
                sum += orderPrice;
            }
            Console.WriteLine($"Total: ${sum:f2}");
        }
    }
}