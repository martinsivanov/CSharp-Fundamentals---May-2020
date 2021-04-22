using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Tanks_Collector
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(", ").ToList();

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string[] commands = Console.ReadLine().Split(", ");

                if (commands[0] == "Add")
                {
                    string tankName = commands[1];
                    if (list.Contains(tankName))
                    {
                        Console.WriteLine("Tank is already bought");
                    }
                    else
                    {
                        list.Add(tankName);
                        Console.WriteLine("Tank successfully bought");
                    }
                }
                else if (commands[0] == "Remove")
                {
                    string tankName = commands[1];
                    if (list.Contains(tankName))
                    {
                        Console.WriteLine("Tank successfully sold");
                        list.Remove(tankName);
                    }
                    else
                    {
                        Console.WriteLine("Tank not found");
                    }
                }
                else if (commands[0] == "Remove At")
                {
                    int index = int.Parse(commands[1]);
                    if (index >= 0 && index < list.Count)
                    {
                        
                        Console.WriteLine("Tank successfully sold");
                        list.RemoveAt(index);
                    }
                    else
                    {
                        Console.WriteLine("Index out of range");
                    }
                }
                else if (commands[0] == "Insert")
                {
                    int index = int.Parse(commands[1]);
                    string tankName = commands[2];
                    if (index >= 0 && index < list.Count)
                    {
                        if (!list.Contains(tankName))
                        {
                            Console.WriteLine("Tank successfully bought");
                            list.Insert(index, tankName);
                        }
                        else
                        {
                            Console.WriteLine("Tank is already bought");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Index out of range");
                    }
                }
            }

            Console.WriteLine(String.Join(", ", list));
        }
    }
}
