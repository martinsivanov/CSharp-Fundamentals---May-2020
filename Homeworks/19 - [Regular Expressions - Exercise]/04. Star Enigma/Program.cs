using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04._Star_Enigma
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> list = new Dictionary<string, string>();
            List<string> attack = new List<string>();
            List<string> destruct = new List<string>();

            int n = int.Parse(Console.ReadLine()); // 

            string pattern = @"[SsTtAaRr]";

            for (int i = 0; i < n; i++)
            {

                string input = Console.ReadLine();


                var Matches = Regex.Matches(input, pattern);
                int count = Matches.Count;

                string decryptMassage = null;

                foreach (var character in input)
                {
                    decryptMassage += (char)(character - count);
                }


                string patternNext = @"[^@\-!:>]*?@(?<planet>[A-Z]+[a-z]+)[^@\-!:>]*?\:[^@\-!:>]*?(?<population>\d+)[^@\-!:>]*?![^@\-!:>]*?(?<attackType>[AD])[^@\-!:>]*?![^@\-!:>]*?->[^@\-!:>]*?(?<solderCount>\d+)[^@\-!:>]*";

                var collections = Regex.Matches(decryptMassage, patternNext);

                foreach (Match match in collections)
                {
                    if (match.Success)
                    {
                        string planetName = match.Groups["planet"].Value;
                        string attackType = match.Groups["attackType"].Value;

                        if (attackType == "A")
                        {
                            attack.Add(planetName);
                        }
                        if (attackType == "D")
                        {
                            destruct.Add(planetName);
                        }

                    }
                }

            }

            Console.WriteLine($"Attacked planets: {attack.Count}");
            if (attack.Count > 0)
            {
                foreach (var item in attack.OrderBy(m => m))
                {
                    Console.WriteLine($"-> {item}");
                }
            }
            Console.WriteLine($"Destroyed planets: {destruct.Count}");
            if (destruct.Count > 0)
            {
                foreach (var item in destruct.OrderBy(m => m))
                {
                    Console.WriteLine($"-> {item}");
                }
            }


        }
    }
}
