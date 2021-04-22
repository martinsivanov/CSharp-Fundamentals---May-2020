using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> list = new Dictionary<string, List<string>>();


            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End")
                {
                    break;
                }

                string[] tokens = command.Split(" -> ").ToArray();

                string name = tokens[0];
                string id = tokens[1];

                if (!list.ContainsKey(name))
                {
                    list.Add(name, new List<string>());
                }
                if (!list[name].Contains(id))
                {
                    list[name].Add(id);
                }

            }

            list = list.OrderBy(c => c.Key).ToDictionary(a => a.Key, b => b.Value);

            foreach (var kvp in list)
            {
                Console.WriteLine($"{kvp.Key}");
                foreach (var item in kvp.Value)
                {
                    Console.WriteLine($"-- {item}");
                }
            }
        }
    }
}
