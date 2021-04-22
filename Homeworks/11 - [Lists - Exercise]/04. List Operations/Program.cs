using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] tokens = command.Split();

                if (tokens[0] == "Add")
                {
                    int number = int.Parse(tokens[1]);
                    list.Add(number);
                }
                else if (tokens[0] == "Insert")
                {
                    int number = int.Parse(tokens[1]);
                    int index = int.Parse(tokens[2]);
                    if (index < 0 || index >= list.Count)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        list.Insert(index, number);
                    }

                }
                else if (tokens[0] == "Remove")
                {
                    int index = int.Parse(tokens[1]);
                    if (index < 0 || index >= list.Count)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        list.RemoveAt(index);
                    }


                }
                else if (tokens[0] == "Shift")
                {

                    if (tokens[1] == "left")
                    {

                        int count = int.Parse(tokens[2]);
                        int first = list[0];
                        int last = list[list.Count - 1];

                        for (int i = 0; i < count; i++)
                        {
                            list.Add(list[0]);
                            list.Remove(list[0]);
                        }

                    }
                    else if (tokens[1] == "right")
                    {
                        int count = int.Parse(tokens[2]);


                        for (int i = 0; i < count; i++)
                        {
                            list.Insert(0, list[list.Count - 1]);
                            list.RemoveAt(list.Count - 1);
                        }
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ", list));
        }
    }
}
