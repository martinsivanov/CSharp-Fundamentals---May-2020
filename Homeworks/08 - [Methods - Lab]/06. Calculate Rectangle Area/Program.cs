﻿using System;

namespace _06._Calculate_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double area = SumArea(width, height);
            Console.WriteLine(area);
        }

        static double SumArea(double width, double height)
        {
            return width * height;
        }
    }
}
