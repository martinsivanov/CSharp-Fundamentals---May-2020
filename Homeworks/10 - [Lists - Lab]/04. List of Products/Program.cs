﻿using System;
using System.Collections.Generic;

namespace _04._List_of_Products
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> product = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string currProduct = Console.ReadLine();
                product.Add(currProduct);
            }
            product.Sort();

            for (int i = 0; i < n; i++)
            {

                Console.WriteLine($"{i + 1}.{product[i]}");
            }
        }
    }
}
