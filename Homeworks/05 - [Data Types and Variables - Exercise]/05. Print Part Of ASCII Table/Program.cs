﻿using System;

namespace _05._Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            string sum = "";
            for (int i = start; i <= end; i++)
            {
                string asciiChar = ((char)i).ToString();
                Console.Write(asciiChar + " ");
            }
        }
    }
}