using System;

namespace _03._Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stringToBeRemoved = Console.ReadLine();
            string stringToManipulate = Console.ReadLine();
            int keyLength = stringToBeRemoved.Length;

            bool isClear = false;
            while (true)
            {

                if (!isClear)
                {
                    if (stringToManipulate.Contains(stringToBeRemoved))
                    {
                        int indexToStart = stringToManipulate.IndexOf(stringToBeRemoved);
                        stringToManipulate = stringToManipulate.Remove(indexToStart, keyLength);
                    }
                    else
                    {
                        isClear = true;
                    }
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(stringToManipulate);
        }
    }
}
