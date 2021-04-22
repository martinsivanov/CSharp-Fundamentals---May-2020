﻿using System;
using System.Linq;

namespace _04._Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split()
                .Select(int.Parse).OrderByDescending(n => n).Take(3).ToArray();

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
