using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] tokens = command.Split();
                if (tokens[0] == "Delete")
                {
                    int num = int.Parse(tokens[1]);

                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] == num)
                        {
                            list.RemoveAt(i);
                            i--;
                        }
                    }
                }
                else if ((tokens[0] == "Insert"))
                {
                    int element = int.Parse(tokens[1]);
                    int position = int.Parse(tokens[2]);

                    list.Insert(position, element);
                }


                command = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ", list));
        }
    }
}
