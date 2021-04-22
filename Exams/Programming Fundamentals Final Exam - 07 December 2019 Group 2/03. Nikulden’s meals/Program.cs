using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Nikulden_s_meals
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, List<string>> allGuests = new Dictionary<string, List<string>>();
            string input = null;
            int UnlikesCount = 0;
            while ((input = Console.ReadLine()) != "Stop")
            {
                string[] commands = input.Split("-", StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (commands.Contains("Like"))
                {
                    string guest = commands[1];
                    string meal = commands[2];

                    if (!allGuests.ContainsKey(guest))
                    {
                        allGuests.Add(guest, new List<string>());
                        allGuests[guest].Add(meal);

                    }
                    if (!allGuests[guest].Contains(meal))
                    {
                        allGuests[guest].Add(meal);
                    }

                }
                if (commands.Contains("Unlike"))
                {
                    string guest = commands[1];
                    string meal = commands[2];


                    if (!allGuests.ContainsKey(guest))
                    {
                        Console.WriteLine($"{guest} is not at the party.");
                        continue;
                    }
                    if (!allGuests[guest].Contains(meal))
                    {
                        Console.WriteLine($"{guest} doesn't have the {meal} in his/her collection.");
                    }
                    else
                    {

                        UnlikesCount++;
                        Console.WriteLine($"{guest} doesn't like the {meal}.");
                        allGuests[guest].Remove(meal);

                    }
                }



            }

            allGuests = allGuests.OrderByDescending(m => m.Value.Count).ThenBy(n => n.Key).ToDictionary(a => a.Key, b => b.Value);
            int count = 0;
            foreach (var guest in allGuests)
            {
                Console.Write($"{guest.Key}: ");

                foreach (var meal in guest.Value)
                {
                    count++;
                    if (count == guest.Value.Count)
                    {
                        Console.Write(meal);
                    }
                    else
                    {
                        Console.Write($"{meal}, ");
                    }
                }
                count = 0;
                Console.WriteLine();
            }
            Console.WriteLine($"Unliked meals: {UnlikesCount}");
        }
    }
}
