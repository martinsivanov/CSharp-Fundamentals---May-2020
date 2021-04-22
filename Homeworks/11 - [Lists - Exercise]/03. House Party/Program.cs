using System;
using System.Collections.Generic;

namespace _03._House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> list = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string[] commands = Console.ReadLine().Split();

                string name = commands[0];
                if (commands.Length == 3)
                {

                    if (list.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        list.Add(name);
                    }


                }
                else if (commands.Length == 4)
                {
                    if (list.Contains(name) == false)
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                    else
                    {
                        list.Remove(name);
                    }
                }
            }
            Console.WriteLine(String.Join(Environment.NewLine, list));
        }
    }
}
