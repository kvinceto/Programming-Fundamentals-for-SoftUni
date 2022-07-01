using System;
using System.Linq;

namespace _04._Array_Rotation
{
    internal class Program
    {
        static void Main()
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rotations = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotations; i++)
            {
                int[] newArray = new int[array.Length];
                for (int j = 0; j < array.Length - 1; j++)
                {
                    newArray[j] = array[j + 1];
                }

                newArray[array.Length - 1] = array[0];
                array = newArray;
            }
            Console.WriteLine(string.Join(' ', array));
        }
    }
}
