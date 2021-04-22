using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.BattleManager
{
    class People
    {
        public int health { get; set; }
        public int energy { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, People> allPeople = new Dictionary<string, People>();

            string input = Console.ReadLine();

            while (input != "Results")
            {

                string[] commands = input.Split(":").ToArray();

                if (commands.Contains("Add"))
                {
                    string name = commands[1];
                    int health = int.Parse(commands[2]);
                    int energy = int.Parse(commands[3]);


                    if (!allPeople.ContainsKey(name))
                    {
                        allPeople.Add(name, new People());
                        allPeople[name].health += health;
                        allPeople[name].energy += energy;

                    }
                    else
                    {
                        allPeople[name].health += health;
                    }
                }
                else if (commands.Contains("Attack"))
                {
                    string attackName = commands[1];
                    string defendName = commands[2];
                    int damage = int.Parse(commands[3]);
                    if (allPeople.ContainsKey(attackName) && allPeople.ContainsKey(defendName))
                    {
                        allPeople[defendName].health -= damage;
                        allPeople[attackName].energy -= 1;
                        if (allPeople[defendName].health <= 0)
                        {
                            Console.WriteLine($"{defendName} was disqualified!");
                            allPeople.Remove(defendName);
                        }
                        if (allPeople[attackName].energy <= 0)
                        {
                            Console.WriteLine($"{attackName} was disqualified!");
                            allPeople.Remove(attackName);
                        }
                    }
                }
                else if (commands.Contains("Delete"))
                {
                    string userName = commands[1];
                    if (allPeople.ContainsKey(userName))
                    {
                        allPeople.Remove(userName);
                    }
                    if (userName == "All")
                    {
                        allPeople.Clear();
                    }
                }



                input = Console.ReadLine();
            }

            allPeople = allPeople.OrderByDescending(e => e.Value.health).ThenBy(n => n.Key).ToDictionary(a => a.Key, b => b.Value);

            Console.WriteLine($"People count: {allPeople.Keys.Count}");
            foreach (var people in allPeople)
            {
                Console.WriteLine($"{people.Key} - {people.Value.health} - {people.Value.energy}");
            }
        }
    }
}
