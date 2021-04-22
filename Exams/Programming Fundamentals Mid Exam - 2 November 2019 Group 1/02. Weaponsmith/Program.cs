using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Weaponsmith
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split("|").ToList();

            string command = Console.ReadLine();

            while (command != "Done")
            {
                string[] commandElements = command.Split();
                if (commandElements[0] == "Move")
                {
                    if (commandElements[1] == "Left")
                    {
                        int index = int.Parse(commandElements[2]);

                        if (index > 0 && index < list.Count)
                        {
                            string oldString = list[index]; // 1  3 4 
                            list.RemoveAt(index);
                            list.Insert(index - 1, oldString);
                        }
                    }
                    else if (commandElements[1] == "Right")
                    {
                        int index = int.Parse(commandElements[2]);

                        if (index >= 0 && index < list.Count - 1)
                        {
                            string oldString = list[index]; // 1  3 4 
                            list.RemoveAt(index);
                            list.Insert(index + 1, oldString);
                        }
                    }
                }
                else if (commandElements[0] == "Check")
                {
                    if (commandElements[1] == "Even")
                    {
                        List<string> evenNums = new List<string>();
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (i % 2 == 0)
                            {
                                string temp = list[i];
                                evenNums.Add(temp);
                            }
                        }
                        Console.WriteLine(String.Join(" ", evenNums));
                    }
                    else if (commandElements[1] == "Odd")
                    {
                        List<string> oddNums = new List<string>();
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (i % 2 != 0)
                            {
                                string temp = list[i];
                                oddNums.Add(temp);
                            }
                        }
                        Console.WriteLine(String.Join(" ", oddNums));
                    }
                }

                command = Console.ReadLine();
            }

            string wheaponCraft = string.Empty;

            for (int i = 0; i < list.Count; i++)
            {
                wheaponCraft += list[i];
            }
            Console.WriteLine($"You crafted {wheaponCraft}!");
        }
    }
}
