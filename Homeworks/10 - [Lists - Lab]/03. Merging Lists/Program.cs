using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> first = Console.ReadLine()
                  .Split()
                  .Select(int.Parse)
                  .ToList();
            List<int> second = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> merged = new List<int>();

            if (first.Count >= second.Count)
            {

                for (int i = 0; i < first.Count; i++)
                {
                    merged.Add(first[i]);
                    if (i < second.Count)
                    {
                        merged.Add(second[i]);
                    }
                }
            }
            else
            {
                for (int i = 0; i < second.Count; i++)
                {
                    if (i < first.Count)
                    {
                        merged.Add(first[i]);
                    }
                    merged.Add(second[i]);
                }
            }
            Console.WriteLine(string.Join(" ", merged));
        }
    }
}
