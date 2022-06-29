using System;

namespace _05._Decrypting_Message
{
    internal class Program
    {
        static void Main()
        {
            int key = int.Parse(Console.ReadLine());
            int numberOfLines = int.Parse(Console.ReadLine());
            string output = String.Empty;
            for (int i = 1; i <= numberOfLines; i++)
            {
                char ch = char.Parse(Console.ReadLine());
                output += (char)((int)ch + key);
            }

            Console.WriteLine(output);
        }
    }
}
