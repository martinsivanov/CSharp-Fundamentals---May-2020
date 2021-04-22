using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MovingTarget
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] CommandsElements = command.Split();

                if (CommandsElements[0] == "Shoot")
                {
                    int index = int.Parse(CommandsElements[1]);
                    int power = int.Parse(CommandsElements[2]);

                    if (index >= 0 && index < list.Count)
                    {
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (list[i] == list[index])
                            {
                                list[i] -= power;
                                if (list[i] <= 0)
                                {
                                    list.RemoveAt(i);
                                }
                            }

                        }
                    }

                }
                else if (CommandsElements[0] == "Add")
                {
                    int index = int.Parse(CommandsElements[1]);
                    int value = int.Parse(CommandsElements[2]);

                    if (index >= 0 && index < list.Count)
                    {
                        list.Insert(index, value);

                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }

                }
                else if (CommandsElements[0] == "Strike")
                {
                    int index = int.Parse(CommandsElements[1]);
                    int radius = int.Parse(CommandsElements[2]);
                    // 0  1  2  3  4   5
                    // 52 74 23 44 96 110
                    // strike 2 2

                    int radiusLeft = index - radius;
                    int radiusRight = index + radius;

                    if (radiusLeft >= 0 && radiusLeft < list.Count && radiusRight >= 0 && radiusRight < list.Count)
                    {
                        list.RemoveRange(radiusLeft, radiusRight - radiusLeft + 1);
                    }
                    else
                    {
                        Console.WriteLine("Strike missed!");
                    }

                }


                command = Console.ReadLine();
            }
            Console.WriteLine(String.Join("|",list));

        }
    }
}
