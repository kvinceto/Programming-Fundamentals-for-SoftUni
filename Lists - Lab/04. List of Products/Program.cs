using System;
using System.Collections.Generic;

namespace _04._List_of_Products
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfProducts = int.Parse(Console.ReadLine());
            List<string> productsList = new List<string>();

            for (int i = 0; i < numberOfProducts; i++)
            {
                productsList.Add(Console.ReadLine());
            }
            productsList.Sort();
            for (int i = 0; i < numberOfProducts; i++)
            {
                Console.WriteLine($"{i+1}.{productsList[i]}");
            }
        }
    }
}
