using System;
using System.Linq;
using System.Threading;

namespace _08._Condense_Array_to_Number
{
    internal class Program
    {
        static void Main()
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            while (nums.Length > 1)
            {
                int[] condenstArray = new int[nums.Length - 1];
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    condenstArray[i] = nums[i] + nums[i + 1];
                }
                nums = condenstArray;

            }

            Console.WriteLine(string.Join(' ', nums));
        }
    }
}
