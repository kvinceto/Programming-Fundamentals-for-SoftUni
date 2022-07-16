using System;
using System.Collections.Generic;

namespace _01._Valid_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] users = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            List<string> validUsers = new List<string>();

            foreach (string user in users)
            {
                if (user.Length > 3 && user.Length < 16)
                {
                    bool isValidUser = true;
                    for (int i = 0; i < user.Length; i++)
                    {
                        char currentChar = user[i];
                        isValidUser = IsCurrentCharacterValid(currentChar);

                        if (!isValidUser)
                        {
                            break;
                        }
                    }

                    if (isValidUser)
                    {
                        validUsers.Add(user);
                    }
                }

            }
            validUsers.ForEach(Console.WriteLine);

            static bool IsCurrentCharacterValid(char currentChar)
            {
                bool isValid = Char.IsDigit(currentChar) || Char.IsLetter(currentChar) ||
                               currentChar == '-' || currentChar == '_';
                return isValid;
            }
        }
    }
}
