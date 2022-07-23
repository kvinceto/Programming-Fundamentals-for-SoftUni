using System;

namespace _01._The_Imitation_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (true)
            {
                string[] command = Console.ReadLine()
                    .Split('|', StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "Decode")
                {
                    break;
                }

                if (command[0] == "Move")
                {
                    int numberOfLettersToMove = int.Parse(command[1]);
                    string substring = input.Substring(0, numberOfLettersToMove);
                    input = input.Remove(0, numberOfLettersToMove);
                    input += substring;
                }
                else if (command[0] == "Insert")
                {
                    int indexToInsert = int.Parse(command[1]);
                    string stringToInsert = command[2];
                    input = input.Insert(indexToInsert, stringToInsert);
                }
                else if (command[0] == "ChangeAll")
                {
                    string stringToBeChanged = command[1];
                    string stringToChangedWith = command[2];

                    while (input.Contains(stringToBeChanged))
                    {
                        input = input.Replace(stringToBeChanged, stringToChangedWith);
                    }
                }
            }

            Console.WriteLine($"The decrypted message is: {input}");
        }
    }
}
