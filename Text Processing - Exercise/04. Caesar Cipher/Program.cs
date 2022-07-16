using System;

namespace _04._Caesar_Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string output = String.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                int currentCharValue = (int)input[i];
                int nextCharValue = currentCharValue + 3;
                char encryptedChar = (char)nextCharValue;
                output += encryptedChar;
            }

            Console.WriteLine(output);
        }
    }
}
