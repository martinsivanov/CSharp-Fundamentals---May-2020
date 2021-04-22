using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();


            while (command != "end")
            {
                string[] tokens = command.Split();
                if (tokens[0] == "Add")
                {
                    int num = int.Parse(tokens[1]);

                    numbers.Add(num);

                }
                else if (tokens[0] == "Remove")
                {
                    int num = int.Parse(tokens[1]);

                    numbers.Remove(num);
                }
                else if (tokens[0] == "RemoveAt")
                {
                    int num = int.Parse(tokens[1]);

                    numbers.RemoveAt(num);
                }
                else if (tokens[0] == "Insert")
                {
                    int num = int.Parse(tokens[1]);
                    int index = int.Parse(tokens[2]);

                    numbers.Insert(index, num);

                }

                command = Console.ReadLine();
            }
            if (command == "end")
            {
                Console.WriteLine(String.Join(" ", numbers));
            }
        }
    }
}
