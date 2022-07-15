using System;

namespace _01._Reverse_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string input = Console.ReadLine();

           while (input != "end")
           {
               string reversedInput = String.Empty;
               for (int i = input.Length - 1; i >= 0; i--)
               {
                   reversedInput += input[i];
               }

               Console.WriteLine($"{input} = {reversedInput}");
               input = Console.ReadLine();
           }
        }
    }
}
