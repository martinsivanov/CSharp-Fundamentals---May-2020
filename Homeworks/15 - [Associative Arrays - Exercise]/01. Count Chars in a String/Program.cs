using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split().ToArray();
            Dictionary<char, int> dc = new Dictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                string current = text[i];

                for (int j = 0; j < current.Length; j++)
                {
                    char curr = current[j];
                    if (!dc.ContainsKey(curr))
                    {
                        dc.Add(curr, 1);
                    }
                    else
                    {
                        dc[curr]++;
                    }
                }

            }

            foreach (var kvp in dc)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
