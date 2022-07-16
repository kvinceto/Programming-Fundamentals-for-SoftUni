using System;

namespace _08._Letters_Change_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputData = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            double sumOfAll = 0.00;

            for (int i = 0; i < inputData.Length; i++)
            {
                string currentString = inputData[i];
                char firstLetter = currentString[0];
                char lastLetter = currentString[currentString.Length - 1];
                currentString = currentString.Remove(0, 1);
                currentString = currentString.Remove(currentString.Length - 1, 1);
                double currentNumber = double.Parse(currentString);
                double firstLetterValue = GetLetterValue(firstLetter);
                double lastLetterValue = GetLetterValue(lastLetter);

                if (Char.IsUpper(firstLetter))
                {
                    currentNumber /= firstLetterValue;
                    if (Char.IsUpper(lastLetter))
                    {
                        currentNumber -= lastLetterValue;
                    }
                    else
                    {
                        currentNumber += lastLetterValue;
                    }
                }
                else
                {
                    currentNumber *= firstLetterValue;
                    if (Char.IsUpper(lastLetter))
                    {
                        currentNumber -= lastLetterValue;
                    }
                    else
                    {
                        currentNumber += lastLetterValue;
                    }
                }

                sumOfAll += currentNumber;
            }

            Console.WriteLine($"{sumOfAll:f2}");

        }

        private static double GetLetterValue(char firstLetter)
        {
            double value = 0;

            switch (firstLetter)
            {
                case 'A':
                case 'a':
                    value = 1;
                    break;
                case 'B':
                case 'b':
                    value = 2;
                    break;
                case 'C':
                case 'c':
                    value = 3;
                    break;
                case 'D':
                case 'd':
                    value = 4;
                    break;
                case 'E':
                case 'e':
                    value = 5;
                    break;
                case 'F':
                case 'f':
                    value = 6;
                    break;
                case 'G':
                case 'g':
                    value = 7;
                    break;
                case 'H':
                case 'h':
                    value = 8;
                    break;
                case 'I':
                case 'i':
                    value = 9;
                    break;
                case 'J':
                case 'j':
                    value = 10;
                    break;
                case 'K':
                case 'k':
                    value = 11;
                    break;
                case 'L':
                case 'l':
                    value = 12;
                    break;
                case 'M':
                case 'm':
                    value = 13;
                    break;
                case 'N':
                case 'n':
                    value = 14;
                    break;
                case 'O':
                case 'o':
                    value = 15;
                    break;
                case 'P':
                case 'p':
                    value = 16;
                    break;
                case 'Q':
                case 'q':
                    value = 17;
                    break;
                case 'R':
                case 'r':
                    value = 18;
                    break;
                case 'S':
                case 's':
                    value = 19;
                    break;
                case 'T':
                case 't':
                    value = 20;
                    break;
                case 'U':
                case 'u':
                    value = 21;
                    break;
                case 'V':
                case 'v':
                    value = 22;
                    break;
                case 'W':
                case 'w':
                    value = 23;
                    break;
                case 'X':
                case 'x':
                    value = 24;
                    break;
                case 'Y':
                case 'y':
                    value = 25;
                    break;
                case 'Z':
                case 'z':
                    value = 26;
                    break;
            }

            return value;
        }
    }
}
