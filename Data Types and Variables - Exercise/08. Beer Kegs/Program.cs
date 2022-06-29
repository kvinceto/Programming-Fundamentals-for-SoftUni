using System;

namespace _08._Beer_Kegs
{
    internal class Program
    {
        static void Main()
        {
            int numberOfKegs = int.Parse(Console.ReadLine());
            double biggestKegVolume = double.MinValue;
            string biggestKegName = String.Empty;

            for (int i = 1; i <= numberOfKegs; i++)
            {
                string kegModel = Console.ReadLine();
                double kegRadius = double.Parse(Console.ReadLine());
                int kegHeight = int.Parse(Console.ReadLine());
                double currentKegVolume = Math.PI * kegRadius * kegRadius * kegHeight;
                if (currentKegVolume >= biggestKegVolume)
                {
                    biggestKegVolume = currentKegVolume;
                    biggestKegName = kegModel;
                }
            }

            Console.WriteLine(biggestKegName);
        }
    }
}
