using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.SchoolLibary
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split("&").ToList();

            string command = Console.ReadLine();

            while (command != "Done")
            {
                string[] commandsElements = command.Split(" | ");

                if (commandsElements[0] == "Add Book")
                {
                    AddBookIfNotExist(list, commandsElements);

                }
                else if (commandsElements[0] == "Take Book")
                {
                    TakeBookIfExist(list, commandsElements);
                }
                else if (commandsElements[0] == "Swap Books")
                {
                    string book1 = commandsElements[1];
                    string book2 = commandsElements[2];
                    if (list.Contains(book1) && list.Contains(book2))
                    {
                        int temp1 = list.IndexOf(book1);
                        int temp2 = list.IndexOf(book2);
                        list.RemoveAt(temp2);
                        list.RemoveAt(temp1);
                       

                        list.Insert(temp1, book2);
                        list.Insert(temp2, book1);

                    }

                }
                else if (commandsElements[0] == "Insert Book")
                {
                    string name = commandsElements[1];
                    list.Add(name);

                }
                else if (commandsElements[0] == "Check Book")
                {
                    int index = int.Parse(commandsElements[1]);
                    if (index >= 0 && index <= list.Count)
                    {
                        Console.WriteLine(list[index]);
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(String.Join(", ", list));
        }

        private static void TakeBookIfExist(List<string> list, string[] commandsElements)
        {
            string name = commandsElements[1];

            if (list.Contains(name))
            {
                list.Remove(name);
            }
        }

        private static void AddBookIfNotExist(List<string> list, string[] commandsElements)
        {
            string bookName = commandsElements[1];
            if (!list.Contains(bookName))
            {
                list.Insert(0, bookName);
            }
        }
    }
}
