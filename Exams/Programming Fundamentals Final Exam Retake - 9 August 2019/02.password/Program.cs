using System;
using System.Text.RegularExpressions;

namespace _02.password
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(.+)>(?<numbers>\d{3})\|(?<lower>[a-z]{3})\|(?<upper>[A-Z]+)\|(?<except>[^<>]{3})<\1";
            string password = string.Empty;
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                Match match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    string numbers = match.Groups["numbers"].Value;
                    string lower = match.Groups["lower"].Value;
                    string upper = match.Groups["upper"].Value;
                    string except = match.Groups["except"].Value;

                    password+= numbers;
                    password+= lower;
                    password+= upper;
                    password+= except;
                    Console.WriteLine($"Password: {password}");

                }
                else
                {
                    Console.WriteLine("Try another password!");
                }
                password = string.Empty;
            }
        }
    }
}
