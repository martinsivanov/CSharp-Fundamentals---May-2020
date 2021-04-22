using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Wizard_Poker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(":").ToList();
            List<string> newList = new List<string>();
            string command = Console.ReadLine();

            while (command != "Ready")
            {
                string[] commandElements = command.Split();

                if (commandElements[0] == "Add")
                {
                    string name = commandElements[1];
                    if (list.Contains(name))
                    {
                        newList.Add(name);
                    }
                    else
                    {
                        Console.WriteLine("Card not found.");
                    }
                }
                else if (commandElements[0] == "Insert")
                {
                    string cardName = commandElements[1];
                    int index = int.Parse(commandElements[2]);
                    if (index >= 0 && index < list.Count && list.Contains(cardName))
                    {
                        newList.Insert(index, cardName);
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }
                }
                else if (commandElements[0] == "Remove")
                {
                    string cardName = commandElements[1];

                    if (newList.Contains(cardName))
                    {
                        newList.Remove(cardName);
                    }
                    else
                    {
                        Console.WriteLine("Card not found.");
                    }
                }
                else if (commandElements[0] == "Swap")
                {
                    string cardName1 = commandElements[1];
                    string cardName2 = commandElements[2];

                    int index1 = newList.IndexOf(cardName1);
                    int index2 = newList.IndexOf(cardName2);

                    newList.RemoveAt(index2);
                    newList.RemoveAt(index1);
                    

                    newList.Insert(index1, cardName2);
                    newList.Insert(index2, cardName1);

                }
                else if (commandElements[0] == "Shuffle" && commandElements[1] == "deck")
                {
                    newList.Reverse();
                }


                command = Console.ReadLine();
            }

            Console.WriteLine(String.Join(" ", newList));
        }
    }
}
