using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Hero_Recruitment
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> AllHeros = new Dictionary<string, List<string>>();
            string input = Console.ReadLine();


            while (input != "End")
            {
                string[] commands = input.Split().ToArray();

                if (commands.Contains("Enroll"))
                {
                    string name = commands[1];
                    if (!AllHeros.ContainsKey(name))
                    {
                        AllHeros.Add(name, new List<string>());

                    }
                    else
                    {
                        Console.WriteLine($"{name} is already enrolled.");
                    }


                }
                else if (commands.Contains("Learn"))
                {

                    string name = commands[1];
                    string spellName = commands[2];

                    if (!AllHeros.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} doesn't exist.");
                    }
                    else if (AllHeros[name].Contains(spellName))
                    {
                        Console.WriteLine($"{name} has already learnt {spellName}.");
                    }
                    else
                    {
                        AllHeros[name].Add(spellName);
                    }


                }
                else if (commands.Contains("Unlearn"))
                {
                    string name = commands[1];
                    string spellName = commands[2];

                    if (!AllHeros.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} doesn't exist.");
                    }
                    else if (!AllHeros[name].Contains(spellName))
                    {
                        Console.WriteLine($"{name} doesn't know {spellName}.");
                    }
                    else
                    {
                        AllHeros[name].Remove(spellName);
                    }

                }

                input = Console.ReadLine();
            }

            AllHeros = AllHeros.OrderByDescending(s => s.Value.Count).ThenBy(n => n.Key).ToDictionary(a => a.Key, b => b.Value);

            Console.WriteLine("Heroes:");

            foreach (var hero in AllHeros)
            {
                Console.Write($"== {hero.Key}: ");


                int count = 0;
                foreach (var spells in hero.Value)
                {
                    count++;
                    if (count == hero.Value.Count)
                    {
                        Console.Write($"{spells}");
                    }
                    else
                    {
                        Console.Write($"{spells}, ");
                    }

                }
                Console.WriteLine();
            }

        }
    }
}
