using System;
using System.Text.RegularExpressions;

namespace _02._Message_Translator
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^!(?<name>[A-Z][a-z]{2,})!\:\[(?<command>[A-Za-z]{8,})\]$";

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                Match match = Regex.Match(input, pattern);
                if (match.Success)
                {
                    string commandNumbers = string.Empty;
                    string name = match.Groups["name"].Value;
                    string command = match.Groups["command"].Value;

                    for (int j = 0; j < command.Length; j++)
                    {
                        int num = (char)(command[j]);
                        commandNumbers += num + " ";
                    }

                    Console.WriteLine($"{name}: {commandNumbers}");
                }
                else
                {
                    Console.WriteLine("The message is invalid");
                }

            }
        }
    }
}
