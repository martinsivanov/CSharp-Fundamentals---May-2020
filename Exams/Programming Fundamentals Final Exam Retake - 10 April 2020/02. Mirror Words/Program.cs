using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Mirror_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(@|#)(?<firstWord>[A-Za-z]{3,})\1\1(?<secondWord>[A-Za-z]{3,})\1";

            List<string> list = new List<string>();

            string input = Console.ReadLine();

            MatchCollection collection = Regex.Matches(input, pattern);

            if (collection.Count > 0)
            {
                Console.WriteLine($"{collection.Count} word pairs found!");
            }
            else
            {
                Console.WriteLine("No word pairs found!");
            }
            

            foreach (Match match in collection)
            {
                
                string firstWord = match.Groups["firstWord"].Value;
                string secondWord = match.Groups["secondWord"].Value;

                string secondWordReversed = string.Empty;
                
                for (int i = secondWord.Length - 1; i >= 0; i--)
                {
                    secondWordReversed += secondWord[i];
                }
                if (firstWord == secondWordReversed)
                {
                    list.Add($"{firstWord} <=> {secondWord}");
                }

            }
            if (list.Count > 0)
            {
                Console.WriteLine("The mirror words are:");
                Console.Write(String.Join(", ", list));
            }
            else
            {
                Console.WriteLine("No mirror words!");
            }
        }
    }
}
