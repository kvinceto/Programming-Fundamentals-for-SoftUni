using System;
using System.Runtime.ExceptionServices;

namespace _04._Printing_Triangle
{
    internal class Program
    {
        static void Main()
        {
            int start = 1;
            int end = int.Parse(Console.ReadLine());
            for (int i = start; i <= end; i++)
            {
                PrintLine(1,i);
            }

            for (int i = end-1; i >= 1; i--)
            {
                PrintLine(1, i);
            }

        }

        static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");   
            }

            Console.WriteLine();
        }
    }
}
