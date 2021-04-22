using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Friendlist_Maintenance
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(", ").ToList();

            string command = Console.ReadLine();
            int blacklistedNamesCount = 0;
            int lostNamesCount = 0;

            while (command != "Report")
            {
                string[] commandElements = command.Split();

                if (commandElements[0] == "Blacklist")
                {
                    string name = commandElements[1];
                    if (list.Contains(name))
                    {
                        Console.WriteLine($"{name} was blacklisted.");
                        int index = list.IndexOf(name);
                        list.RemoveAt(index);
                        string newName = "Blacklisted";
                        list.Insert(index, newName);
                        blacklistedNamesCount++;
                    }
                    else
                    {
                        Console.WriteLine($"{name} was not found.");
                    }
                }
                else if (commandElements[0] == "Error")
                {
                    int index = int.Parse(commandElements[1]);
                    string name = list[index];
                    if (list[index] == "Blacklisted")
                    {

                    }
                    else if (list[index] == "Lost")
                    {

                    }
                    else
                    {
                        lostNamesCount++;
                        list[index] = "Lost";
                        Console.WriteLine($"{name} was lost due to an error.");
                    }
                    
                    

                }
                else if (commandElements[0] == "Change")
                {
                    int index = int.Parse(commandElements[1]);
                    string newName = commandElements[2];
                    if (index >= 0 && index < list.Count)
                    {
                        string currentName = list[index];
                        list.RemoveAt(index);
                        list.Insert(index, newName);

                        Console.WriteLine($"{currentName} changed his username to {newName}.");
                    }
                }


                command = Console.ReadLine();
            }

            Console.WriteLine($"Blacklisted names: {blacklistedNamesCount}");
            Console.WriteLine($"Lost names: {lostNamesCount}");
            Console.WriteLine(String.Join(" ",list));
        }
    }
}
