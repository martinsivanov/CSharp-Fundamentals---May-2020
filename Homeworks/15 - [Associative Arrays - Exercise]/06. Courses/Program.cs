using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> academy = new Dictionary<string, List<string>>();


            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }

                string[] commandArgs = command.Split(" : ").ToArray();

                string courseName = commandArgs[0];
                string studentName = commandArgs[1];

                if (!academy.ContainsKey(courseName))
                {
                    academy.Add(courseName, new List<string>());
                }

                academy[courseName].Add(studentName);

            }

            academy = academy.OrderByDescending(u => u.Value.Count).ToDictionary(a => a.Key, b => b.Value);

            foreach (var kvp in academy)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count}");

                foreach (var students in kvp.Value.OrderBy(s => s))
                {
                    Console.WriteLine($"-- {students}");
                }
            }
        }
    }
}
