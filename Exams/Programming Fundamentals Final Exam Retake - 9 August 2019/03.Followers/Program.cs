using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Followers
{
    class Followers
    {
        public int likes { get; set; }
        public int comments { get; set; }
        public int total { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Followers> allFollowers = new Dictionary<string, Followers>();

            string input = Console.ReadLine();

            while (input != "Log out")
            {
                string[] commands = input.Split(": ");

                if (commands.Contains("New follower"))
                {
                    string userName = commands[1];
                    if (!allFollowers.ContainsKey(userName))
                    {
                        allFollowers.Add(userName, new Followers());

                        allFollowers[userName].comments = 0;
                        allFollowers[userName].likes = 0;

                    }
                }
                if (commands.Contains("Like"))
                {
                    string userName = commands[1];
                    int count = int.Parse(commands[2]);
                    if (!allFollowers.ContainsKey(userName))
                    {
                        allFollowers.Add(userName, new Followers());
                        allFollowers[userName].likes += count;
                        allFollowers[userName].comments = 0;
                    }
                    else
                    {
                        allFollowers[userName].likes += count;
                    }
                }
                if (commands.Contains("Comment"))
                {

                    string userName = commands[1];
                    if (!allFollowers.ContainsKey(userName))
                    {
                        allFollowers.Add(userName, new Followers());
                        allFollowers[userName].comments += 1;
                        allFollowers[userName].likes = 0;
                    }
                    else
                    {
                        allFollowers[userName].comments += 1;
                    }

                }
                if (commands.Contains("Blocked"))
                {
                    string userName = commands[1];
                    if (allFollowers.ContainsKey(userName))
                    {
                        allFollowers.Remove(userName);
                    }
                    else
                    {
                        Console.WriteLine($"{userName} doesn't exist.");
                    }
                }




                input = Console.ReadLine();
            }

            foreach (var follower in allFollowers)
            {
                follower.Value.total = follower.Value.likes + follower.Value.comments;
            }
            allFollowers = allFollowers.OrderByDescending(t => t.Value.likes).ThenBy(u => u.Key).ToDictionary(a => a.Key, b => b.Value);
            Console.WriteLine($"{allFollowers.Count} followers");
            foreach (var follower in allFollowers)
            {
                Console.WriteLine($"{follower.Key}: {follower.Value.total}");
            }
        }
    }
}
