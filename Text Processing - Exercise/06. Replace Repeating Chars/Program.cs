using System;
using System.Text;

namespace _06._Replace_Repeating_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            StringBuilder stringToChange = new StringBuilder();
            StringBuilder result = new StringBuilder();

            while (true)
            {
                int index = 0;
                stringToChange.Append(text[index]);

                if (text.Length > 1)
                {
                    while (text[index] == text[index + 1])
                    {

                        stringToChange.Append(text[index + 1]);
                        index++;
                        if (index + 1 >= text.Length)
                        {
                            break;
                        }
                    }
                }

                result.Append(text[0]);
                text = text.Remove(0, stringToChange.Length);
                stringToChange.Clear();
                if (text.Length < 2)
                {
                    if (text.Length == 1)
                    {
                        result.Append(text[0]);
                    }
                    break;
                }

            }

            Console.WriteLine(result.ToString());

        }
    }
}
