using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;

namespace _02.ArcheryTournament
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split("|").Select(int.Parse).ToList();

            string command = Console.ReadLine();

            int points = 0;

            while (command != "Game over")
            {

                string[] commandsElements = command.Split();

                if (commandsElements[0] == "Shoot")
                {
                    string[] commands = commandsElements[1].Split("@");
                    if (commands[0] == "Left")
                    {
                        int startIndex = int.Parse(commands[1]);
                        int lenght = int.Parse(commands[2]);
                        //10|10|10|10|10
                        // Shoot Left
                        if (startIndex < 0 || startIndex > list.Count - 1)
                        {

                        }
                        else
                        {
                            for (int i = 0; i < lenght; i++)
                            {
                                startIndex--;
                                if (startIndex < 0)
                                {
                                    startIndex = list.Count - 1;
                                }
                            }
                            list[startIndex] -= 5;
                            points += 5;
                            if (list[startIndex] < 5)
                            {
                                points += list[startIndex];
                                list[startIndex] = 0;

                            }
                        }

                    }
                    else if (commands[0] == "Right")
                    {
                        int startIndex = int.Parse(commands[1]);
                        int lenght = int.Parse(commands[2]);
                        //10|10|10|10|10
                        // Shoot Left
                        if (startIndex < 0 || startIndex > list.Count - 1)
                        {

                        }
                        else
                        {

                            for (int i = 0; i < lenght; i++)
                            {
                                startIndex++;
                                if (startIndex > list.Count - 1)
                                {
                                    startIndex = 0;
                                }
                            }
                            list[startIndex] -= 5;
                            points += 5;

                            if (list[startIndex] < 5)
                            {
                                points += list[startIndex];
                                list[startIndex] = 0;
                               
                            }

                        }
                    }

                }

                else if (commandsElements[0] == "Reverse")
                {
                    list.Reverse();
                }

                command = Console.ReadLine();
            }

            if (command == "Game over")
            {
                Console.WriteLine(String.Join(" - ", list));
                Console.WriteLine($"Iskren finished the archery tournament with {points} points!");
            }
        }
    }
}
