using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(", ").ToList();

            string command = Console.ReadLine();

            while (command != "Craft!")
            {
                string[] commandsElements = command.Split(" - ");

                if (commandsElements[0] == "Collect")
                {
                    CollectItem(list, commandsElements);

                }
                else if (commandsElements[0] == "Drop")
                {
                    DropItem(list, commandsElements);
                }
                else if (commandsElements[0] == "Combine Items")
                {
                    CombineItems(list, commandsElements);

                }
                else if (commandsElements[0] == "Renew")
                {
                    Renew(list, commandsElements);
                }


                command = Console.ReadLine();
            }
            if (command == "Craft!")
            {
                Console.WriteLine(String.Join(", ", list));
            }
        }

        private static void Renew(List<string> list, string[] commandsElements)
        {
            string item = commandsElements[1];

            if (list.Contains(item))
            {
                int index = list.IndexOf(item);
                string temp = list[index];
                list.Remove(item);
                list.Add(temp);
            }
        }

        private static void CombineItems(List<string> list, string[] commandsElements)
        {
            string[] items = commandsElements[1].Split(":");
            string oldItem = items[0];
            string newItem = items[1];
            if (list.Contains(oldItem))
            {
                int index = list.IndexOf(oldItem);
                list.Insert(index + 1, newItem);
            }
        }

        private static void DropItem(List<string> list, string[] commandsElements)
        {
            string item = commandsElements[1];

            if (list.Contains(item))
            {
                list.Remove(item);
            }

        }

        private static void CollectItem(List<string> list, string[] commandsElements)
        {
            string item = commandsElements[1];

            if (list.Contains(item))
            {

            }
            else
            {
                list.Add(item);
            }
        }
    }
}
