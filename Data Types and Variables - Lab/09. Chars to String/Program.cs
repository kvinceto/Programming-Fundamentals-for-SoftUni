using System;

namespace _09._Chars_to_String
{
    internal class Program
    {
        static void Main()
        {
            string output = "";
            for (int i = 0; i < 3; i++)
            {
                char input = char.Parse(Console.ReadLine());
                output += input;
            }
            Console.WriteLine(output);
        }
    }
}
