using System;
using System.Collections.Generic;

namespace _03._Word_Synonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int timesCount = int.Parse(Console.ReadLine());

            var dict = new Dictionary<string, List<string>>();

            for (int i = 0; i < timesCount; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (!dict.ContainsKey(word))
                {
                    dict.Add(word, new List<string>());
                }

                dict[word].Add(synonym);
            }

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ", item.Value)}");
            }
        }
    }
}
