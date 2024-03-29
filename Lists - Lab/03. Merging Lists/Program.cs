﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Merging_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToList();
            List<int> secondList = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToList();
            List<int> resultList = new List<int>();

            while (firstList.Count > 0 && secondList.Count > 0)
            {
                resultList.Add(firstList[0]);
                resultList.Add(secondList[0]);
                firstList.RemoveAt(0);
                secondList.RemoveAt(0);
            }

            if (firstList.Count == 0)
            {
                int iterationsLeft = secondList.Count;
                for (int i = 0; i < iterationsLeft; i++)
                {
                    resultList.Add(secondList[0]);
                    secondList.RemoveAt(0);
                }
            }
            else if (secondList.Count == 0)
            {
                int iterationsLeft = firstList.Count;
                for (int i = 0; i < iterationsLeft; i++)
                {
                    resultList.Add(firstList[0]);
                    firstList.RemoveAt(0);
                }
            }

            Console.WriteLine(string.Join(' ', resultList));

        }
    }
}
