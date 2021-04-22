using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Heroes_of_Code_and_Logic_VII
{

    class Hero
    {
        public int HP { get; set; }
        public int MP { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Hero> allHeros = new Dictionary<string, Hero>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();

                string name = input[0];
                int health = int.Parse(input[1]);
                int mana = int.Parse(input[2]);

                Hero hero = new Hero() { HP = 0, MP = 0 };

                allHeros.Add(name, hero);
                allHeros[name].HP = health;
                allHeros[name].MP = mana;
            }
            string commands = Console.ReadLine();

            while (commands != "End")
            {
                string[] commandsArgs = commands.Split(" - ").ToArray();

                if (commandsArgs.Contains("CastSpell"))
                {
                    string name = commandsArgs[1];
                    int mpNeed = int.Parse(commandsArgs[2]);
                    string spellName = commandsArgs[3];

                    if (allHeros[name].MP >= mpNeed)
                    {
                        allHeros[name].MP -= mpNeed;
                        Console.WriteLine($"{name} has successfully cast {spellName} and now has {allHeros[name].MP} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{name} does not have enough MP to cast {spellName}!");
                    }
                }
                if (commandsArgs.Contains("TakeDamage"))
                {
                    string name = commandsArgs[1];
                    int damage = int.Parse(commandsArgs[2]);
                    string attacker = commandsArgs[3];

                    allHeros[name].HP -= damage;
                    if (allHeros[name].HP <= 0)
                    {
                        Console.WriteLine($"{name} has been killed by {attacker}!");
                        allHeros.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} was hit for {damage} HP by {attacker} and now has {allHeros[name].HP} HP left!");
                    }

                }
                if (commandsArgs.Contains("Recharge"))
                {
                    string name = commandsArgs[1];
                    int mana = int.Parse(commandsArgs[2]);

                    allHeros[name].MP += mana;
                    if (allHeros[name].MP > 200)
                    {
                        allHeros[name].MP -= mana;
                        int left = 200 - allHeros[name].MP;
                        Console.WriteLine($"{name} recharged for {left} MP!");
                        allHeros[name].MP = 200;

                    }
                    else
                    {
                        Console.WriteLine($"{name} recharged for {mana} MP!");
                    }
                }

                if (commandsArgs.Contains("Heal"))
                {
                    string name = commandsArgs[1];
                    int health = int.Parse(commandsArgs[2]);


                    allHeros[name].HP += health;
                    if (allHeros[name].HP > 100)
                    {
                        allHeros[name].HP -= health;
                        int left = 100 - allHeros[name].HP;
                        Console.WriteLine($"{name} healed for {left} HP!");
                        allHeros[name].HP = 100;

                    }
                    else
                    {
                        Console.WriteLine($"{name} healed for {health} HP!");
                    }

                }


                commands = Console.ReadLine();
            }

            allHeros = allHeros.OrderByDescending(m => m.Value.HP).ThenBy(n => n.Key).ToDictionary(a => a.Key, b => b.Value);


            foreach (var hero in allHeros)
            {
                Console.WriteLine(hero.Key);
                Console.WriteLine($"  HP: {hero.Value.HP}");
                Console.WriteLine($"  MP: {hero.Value.MP}");
            }
        }
    }
}
