using System;

namespace _10._Rage_Expenses
{
    internal class Program
    {
        static void Main()
        {
            int lostGameCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());
            double expenses = 0;
            int counter = 0;

            for (int currentGame = 1; currentGame <= lostGameCount; currentGame++)
            {
                if (currentGame % 2 == 0 && currentGame % 3 == 0)
                {
                    expenses += headsetPrice + mousePrice + keyboardPrice;
                    counter++;
                    if (counter != 0 && counter % 2 == 0)
                    {
                        expenses += displayPrice;
                    }
                }
                else if (currentGame % 2 == 0)
                {
                    expenses += headsetPrice;
                }
                else if (currentGame % 3 == 0)
                {
                    expenses += mousePrice;
                }
            }
            Console.WriteLine($"Rage expenses: {expenses:f2} lv.");
        }
    }
}