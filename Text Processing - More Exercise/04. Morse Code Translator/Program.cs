using System;
using System.Collections.Generic;

namespace _04._Morse_Code_Translator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<string> decodedMessage = new List<string>();

            string[] words = input.Split('|');
            foreach (string word in words)
            {
                string currentWord = String.Empty;
                string[] letters = word.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                foreach (var letter in letters)
                {
                    string decodedLetter = GetTheCorrectLetter(letter);
                    currentWord += decodedLetter;
                }
                decodedMessage.Add(currentWord);
            }

            Console.WriteLine(string.Join(' ', decodedMessage));
        }

        private static string GetTheCorrectLetter(string letter)
        {
            string l = String.Empty;

            switch (letter)
            {
                case ".-":
                    l = "A";
                    break;
                case "-...":
                    l = "B";
                    break;
                case "-.-.":
                    l = "C";
                    break;
                case "-..":
                    l = "D";
                    break;
                case ".":
                    l = "E";
                    break;
                case "..-.":
                    l = "F";
                    break;
                case "--.":
                    l = "G";
                    break;
                case "....":
                    l = "H";
                    break;
                case "..":
                    l = "I";
                    break;
                case ".---":
                    l = "J";
                    break;
                case "-.-":
                    l = "K";
                    break;
                case ".-..":
                    l = "L";
                    break;
                case "--":
                    l = "M";
                    break;
                case "-.":
                    l = "N";
                    break;
                case "---":
                    l = "O";
                    break;
                case ".--.":
                    l = "P";
                    break;
                case "--.-":
                    l = "Q";
                    break;
                case ".-.":
                    l = "R";
                    break;
                case "...":
                    l = "S";
                    break;
                case "-":
                    l = "T";
                    break;
                case "..-":
                    l = "U";
                    break;
                case "...-":
                    l = "V";
                    break;
                case ".--":
                    l = "W";
                    break;
                case "-..-":
                    l = "X";
                    break;
                case "-.--":
                    l = "Y";
                    break;
                case "--..":
                    l = "Z";
                    break;
            }
            return l;
        }
    }
}
