﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Word_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ').Where(w => w.Length % 2 == 0).ToArray();
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
            
        }
    }
}
