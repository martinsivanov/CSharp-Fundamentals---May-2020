using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameRegex = @"[A-Za-z]";

            string distanceRegex = @"\d";
            Dictionary<string, int> racers = new Dictionary<string, int>();
            List<string> list = new List<string>();

            string[] listRacers = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            string input = Console.ReadLine(); // G4e@55or%6g6!68e!!@

            while (input != "end of race")
            {

                MatchCollection name = Regex.Matches(input, nameRegex);
                MatchCollection distance = Regex.Matches(input, distanceRegex);

                string names = string.Concat(name);
                int sum = distance.Select(x => int.Parse(x.Value)).Sum();

                if (!racers.ContainsKey(names) && listRacers.Contains(names))
                {
                    racers.Add(names, sum);
                }
                else
                {
                    if (listRacers.Contains(names))
                    {
                        racers[names] += sum;
                    }

                }


                input = Console.ReadLine();
            }


            var final = racers.OrderByDescending(x => x.Value).Select(m => m.Key).Take(3).ToList();

            Console.WriteLine($"1st place: {final[0]}");
            Console.WriteLine($"2nd place: {final[1]}");
            Console.WriteLine($"3rd place: {final[2]}");
        }
    }
}
