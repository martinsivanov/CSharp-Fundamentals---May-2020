using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Mu_Online
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split("|").ToList();

            int health = 100;
            int bitCoins = 0;
            int bestRoom = 0;
            int totalBitCoins = 0;

            for (int i = 0; i < list.Count; i++)
            {
                string room = list[i];

                string[] commands = room.Split();

                if (commands[0] == "potion")
                {
                    int amount = int.Parse(commands[1]);
                    if (amount + health > 100)
                    {
                        int MaxHealth = 100;
                        int temp = 0;
                        health += amount;
                        temp = health - MaxHealth;
                        amount -= temp;
                    }
                    else
                    {
                        health += amount;
                    }
                    
                    if (health > 100)
                    {
                        health = 100;
                    }

                    Console.WriteLine($"You healed for {amount} hp.");
                    Console.WriteLine($"Current health: {health} hp.");

                }
                else if (commands[0] == "chest")
                {
                    int amount = int.Parse(commands[1]);
                    bitCoins = amount;
                    totalBitCoins += bitCoins;
                    Console.WriteLine($"You found {bitCoins} bitcoins.");

                }
                else if (commands[0] != "potion" && commands[0] != "chest")
                {
                    string monster = commands[0];
                    int monsterHP = int.Parse(commands[1]);

                    health -= monsterHP;
                    if (health > 0)
                    {
                        Console.WriteLine($"You slayed {monster}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {monster}.");
                        int bestroom = i + 1;
                        Console.WriteLine($"Best room: {bestroom}");
                        break;
                    }

                }

            }
            if (health > 0)
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine($"Bitcoins: {totalBitCoins}");
                Console.WriteLine($"Health: {health}");
            }
        }
    }
}
