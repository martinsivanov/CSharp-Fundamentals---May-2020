using System;
using System.Linq;

namespace _01.UserName
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            string input = Console.ReadLine();

            while (input != "Sign up")
            {
                string[] commands = input.Split();

                if (commands.Contains("Case"))
                {
                    if (commands[1] == "lower")
                    {
                        userName = userName.ToLower();
                        Console.WriteLine(userName);
                    }
                    else if (commands[1] == "upper")
                    {
                        userName = userName.ToUpper();
                        Console.WriteLine(userName);
                    }
                }
                if (commands.Contains("Reverse"))
                {
                    int startIndex = int.Parse(commands[1]);
                    int endIndex = int.Parse(commands[2]);
                    if (startIndex >= 0 && endIndex > startIndex && endIndex < userName.Length)
                    {

                        string word = userName.Substring(startIndex, (endIndex - startIndex) + 1);
                        Console.WriteLine(string.Join("", word.Reverse()));
                    }

                }
                if (commands.Contains("Cut"))
                {
                    string substring = commands[1];
                    if (userName.Contains(substring))
                    {
                        var index = userName.IndexOf(substring);

                        userName = userName.Remove(index, substring.Length);
                        Console.WriteLine(userName);
                    }
                    else
                    {
                        Console.WriteLine($"The word {userName} doesn't contain {substring}.");
                    }
                }
                if (commands.Contains("Replace"))
                {
                    char letter = char.Parse(commands[1]);
                    userName = userName.Replace(letter, '*');
                    Console.WriteLine(userName);
                }
                if (commands.Contains("Check"))
                {

                    char letter = char.Parse(commands[1]);

                    if (userName.Contains(letter))
                    {
                        Console.WriteLine("Valid");
                    }
                    else
                    {
                        Console.WriteLine($"Your username must contain {letter}.");
                    }
                }




                input = Console.ReadLine();
            }
        }
    }
}
