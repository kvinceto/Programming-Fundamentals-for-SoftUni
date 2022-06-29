using System;

namespace _01._Data_Type_Finder
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int valueInt = 0;
            double valueDouble = 0.0;
            char valueChar = ' ';
            bool valueBoolean = false;

            while (input != "END")
            {
                if (int.TryParse(input, out valueInt))
                {
                    Console.WriteLine($"{input} is integer type");
                }
                else if (double.TryParse(input, out valueDouble))
                {
                    Console.WriteLine($"{input} is floating point type");
                }
                else if (char.TryParse(input, out valueChar))
                {
                    Console.WriteLine($"{input} is character type");
                }
                else if (bool.TryParse(input, out valueBoolean))
                {
                    Console.WriteLine($"{input} is boolean type");
                }
                else
                {
                    Console.WriteLine($"{input} is string type");
                }

                input = Console.ReadLine();
            }
        }
    }
}
