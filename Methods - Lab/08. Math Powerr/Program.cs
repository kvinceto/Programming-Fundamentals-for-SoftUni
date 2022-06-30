using System;

namespace _08._Math_Powerr
{
    internal class Program
    {
        static void Main()
        {
           double baseNum = double.Parse(Console.ReadLine());
           double powerNum = double.Parse(Console.ReadLine());
           double result = NumToPow(baseNum, powerNum);
           Console.WriteLine(result);
        }

        private static double NumToPow(double baseNum, double powerNum)
        {
            double result = Math.Pow(baseNum, powerNum);
            
            return result;
        }
    }
}
