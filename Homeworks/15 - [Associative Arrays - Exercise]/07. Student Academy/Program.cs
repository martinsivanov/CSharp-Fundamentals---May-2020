using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> results = new Dictionary<string, List<double>>();
            Dictionary<string, double> final = new Dictionary<string, double>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!results.ContainsKey(name))
                {
                    results.Add(name, new List<double>());

                }
                results[name].Add(grade);
            }



            foreach (var kvp in results.OrderByDescending(x => x.Value.Average()))
            {
                double resultAvarage = kvp.Value.Average();

                if (resultAvarage >= 4.50)
                {
                    Console.WriteLine($"{kvp.Key} -> {resultAvarage:f2}");

                }
            }
        }
    }
}
