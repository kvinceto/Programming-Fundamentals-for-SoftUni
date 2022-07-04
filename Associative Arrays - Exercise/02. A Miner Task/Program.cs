using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._A_Miner_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            while (true)
            {
                string inputOdd = Console.ReadLine();

                if (inputOdd == "stop")
                {
                    break;
                }
                string inputEven = Console.ReadLine();
                if (dictionary.ContainsKey(inputOdd))
                {
                    dictionary[inputOdd] += int.Parse(inputEven);
                }
                else
                {
                    dictionary.Add(inputOdd, int.Parse(inputEven));
                }
            }

            dictionary.ToList().ForEach(x => Console.WriteLine($"{x.Key} -> {x.Value}"));
        }
    }
}
