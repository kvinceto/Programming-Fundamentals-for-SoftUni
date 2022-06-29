using System;

namespace _01._Sort_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            int numThree = int.Parse(Console.ReadLine());

            if (numOne >= numTwo && numOne >= numThree)
            {
                Console.WriteLine(numOne);
                if (numTwo >= numThree)
                {
                    Console.WriteLine(numTwo);
                    Console.WriteLine(numThree);
                }
                else
                {
                    Console.WriteLine(numThree);
                    Console.WriteLine(numTwo);
                }
            }
            else if (numTwo >= numOne && numTwo >= numThree)
            {
                Console.WriteLine(numTwo);
                if (numOne >= numThree)
                {
                    Console.WriteLine(numOne);
                    Console.WriteLine(numThree);
                }
                else
                {
                    Console.WriteLine(numThree);
                    Console.WriteLine(numOne);
                }
            }
            else if (numThree >= numOne && numThree >= numTwo)
            {
                Console.WriteLine(numThree);
                if (numOne >= numTwo)
                {
                    Console.WriteLine(numOne);
                    Console.WriteLine(numTwo);
                }
                else
                {
                    Console.WriteLine(numTwo);
                    Console.WriteLine(numOne);
                }
            }
        }
    }
}