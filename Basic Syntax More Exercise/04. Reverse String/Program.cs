using System;

namespace _04._Reverse_String
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Console.WriteLine(ReturnString(input));
        }
        public static string ReturnString(string a)
        {
            char[] charArray = a.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}