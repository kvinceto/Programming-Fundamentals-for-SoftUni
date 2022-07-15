using System;
using System.Linq;
using System.Text;

namespace _03._Treasure_Finder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] keys = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToArray();
            StringBuilder newString = new StringBuilder();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "find")
                {
                    break;
                }

                while (input.Length > 0)
                {
                    for (int i = 0; i < keys.Length; i++)
                    {
                        char currentChar = input[0];
                        int key = keys[i];
                        char newChar = (char)((int)currentChar - key);
                        newString.Append(newChar);
                        input = input.Remove(0, 1);
                        if (input.Length < 1)
                        {
                            break;
                        }
                    }
                }

                string newInput = newString.ToString();
                string[] decodeTreasure = newInput.Split('&');
                string treasureName = decodeTreasure[1];
                char[] separators = new char[] { '<', '>' };
                string[] decodeLocation = newInput.Split(separators);
                string treasureLocation = decodeLocation[1];
                newString.Clear();
                Console.WriteLine($"Found {treasureName} at {treasureLocation}");
            }
        }
    }
}
