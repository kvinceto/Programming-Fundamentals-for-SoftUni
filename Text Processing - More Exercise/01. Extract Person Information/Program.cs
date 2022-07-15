using System;

namespace _01._Extract_Person_Information
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberOfLines; i++)
            {
                string input = Console.ReadLine();
                int startIndexOfName = input.IndexOf('@') + 1;
                int endIndexOfName = input.IndexOf('|');
                string name = input.Substring(startIndexOfName, endIndexOfName - startIndexOfName);
                int startIndexOfAge = input.IndexOf('#') + 1;
                int endIndexOfAge = input.IndexOf('*');
                string age = input.Substring(startIndexOfAge, endIndexOfAge - startIndexOfAge);

                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}
