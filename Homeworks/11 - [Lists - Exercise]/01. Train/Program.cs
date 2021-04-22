using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            int capacity = int.Parse(Console.ReadLine());

            var command = Console.ReadLine();

            while (command != "end")
            {
                string[] tokens = command.Split();

                if (tokens[0] == "Add")
                {
                    int number = int.Parse(tokens[1]);

                    list.Add(number);
                }
                else
                {
                    int num2 = int.Parse(tokens[0]);
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] + num2 <= capacity)
                        {
                            list[i] += num2;
                            break;
                        }

                    }
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ", list));
        }
    }
}
