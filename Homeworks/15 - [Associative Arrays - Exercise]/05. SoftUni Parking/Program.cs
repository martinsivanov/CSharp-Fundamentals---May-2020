using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> data = new Dictionary<string, string>();


            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] commands = Console.ReadLine().Split().ToArray();

                if (commands[0] == "register")
                {
                    string user = commands[1];
                    string id = commands[2];

                    if (!data.ContainsKey(user))
                    {
                        data.Add(user, id);
                        Console.WriteLine($"{user} registered {id} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {id}");
                    }


                }
                else
                {
                    string user = commands[1];

                    if (!data.ContainsKey(user))
                    {
                        Console.WriteLine($"ERROR: user {user} not found");
                    }
                    else
                    {
                        data.Remove(user);
                        Console.WriteLine($"{user} unregistered successfully");
                    }
                }

            }

            foreach (var kvp in data)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
        }
    }
}
