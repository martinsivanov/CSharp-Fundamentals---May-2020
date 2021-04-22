using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._P_rates
{
    class Town
    {
        public int population { get; set; }
        public int gold { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, Town> AllTowns = new Dictionary<string, Town>();
            while (input != "Sail")
            {
                string[] inputArgs = input.Split("||").ToArray();
                string name = inputArgs[0];
                int population = int.Parse(inputArgs[1]);
                int gold = int.Parse(inputArgs[2]);

                Town town = new Town() { population = 0, gold = 0 };
                if (!AllTowns.ContainsKey(name))
                {
                    AllTowns.Add(name, town);
                    AllTowns[name].population += population;
                    AllTowns[name].gold += gold;

                }
                else
                {
                    AllTowns[name].population += population;
                    AllTowns[name].gold += gold;
                }
                input = Console.ReadLine();
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] commandArgs = command.Split("=>").ToArray();

                if (commandArgs.Contains("Plunder"))
                {
                    string name = commandArgs[1];
                    int peopleKilled = int.Parse(commandArgs[2]);
                    int goldStolen = int.Parse(commandArgs[3]);


                    if (AllTowns[name].gold - goldStolen <= 0 || AllTowns[name].population - peopleKilled <= 0)
                    {
                        Console.WriteLine($"{name} plundered! {goldStolen} gold stolen, {peopleKilled} citizens killed.");
                        Console.WriteLine($"{name} has been wiped off the map!");
                        AllTowns.Remove(name);
                    }
                    else
                    {
                        AllTowns[name].gold -= goldStolen;
                        AllTowns[name].population -= peopleKilled;
                        Console.WriteLine($"{name} plundered! {goldStolen} gold stolen, {peopleKilled} citizens killed.");

                    }

                }
                if (commandArgs.Contains("Prosper"))
                {
                    string name = commandArgs[1];
                    int goldAdd = int.Parse(commandArgs[2]);

                    if (goldAdd < 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                    }
                    else
                    {
                        AllTowns[name].gold += goldAdd;
                        Console.WriteLine($"{goldAdd} gold added to the city treasury. {name} now has {AllTowns[name].gold} gold.");
                    }

                }



                command = Console.ReadLine();
            }

            AllTowns = AllTowns.OrderByDescending(g => g.Value.gold).ThenBy(n => n.Key).ToDictionary(a => a.Key, b => b.Value);

            Console.WriteLine($"Ahoy, Captain! There are {AllTowns.Count} wealthy settlements to go to:");
            if (AllTowns.Count > 0)
            {
                foreach (var town in AllTowns)
                {
                    
                    Console.WriteLine($"{town.Key} -> Population: {town.Value.population} citizens, Gold: {town.Value.gold} kg");
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }

            
        }
    }
}
