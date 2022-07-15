using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _02._Ascii_Sumator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            string randomString = Console.ReadLine();

            int firstCharValue = (int)firstChar;
            int secondCharValue = (int)secondChar;
            int sumOfAllChars = 0;

            while (randomString.Length > 0)
            {
                char currentChar = randomString[0];
                if ((int)currentChar > firstCharValue && (int)currentChar < secondCharValue)
                {
                    sumOfAllChars += (int)currentChar;
                    randomString = randomString.Remove(0, 1);
                }
                else
                {
                    randomString = randomString.Remove(0, 1);
                }
            }

            Console.WriteLine(sumOfAllChars);
        }
    }
}
