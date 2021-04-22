using System;
using System.Linq;

namespace _01.ActivationKey
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string input = Console.ReadLine();

            while (input != "Generate")
            {
                string[] commands = input.Split(">>>");

                if (commands.Contains("Contains"))
                {
                    string substring = commands[1];

                    if (text.Contains(substring))
                    {
                        Console.WriteLine($"{text} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }

                }
                if (commands.Contains("Flip"))
                {
                    if (commands[1].Contains("Upper"))
                    {
                        int startIndex = int.Parse(commands[2]);
                        int endIndex = int.Parse(commands[3]);
                        string substring = text.Substring(startIndex, endIndex - startIndex);
                        text = text.Replace(substring, substring.ToUpper());
                        Console.WriteLine(text);

                    }
                    else
                    {
                        int startIndex = int.Parse(commands[2]);
                        int endIndex = int.Parse(commands[3]);
                        string substring = text.Substring(startIndex, endIndex - startIndex);
                        text = text.Replace(substring, substring.ToLower());
                        Console.WriteLine(text);

                    }


                }
                if (commands.Contains("Slice"))
                {
                    int startIndex = int.Parse(commands[1]);
                    int endIndex = int.Parse(commands[2]);

                    text = text.Remove(startIndex, endIndex - startIndex);
                    Console.WriteLine(text);
                }


                input = Console.ReadLine();
            }

            Console.WriteLine($"Your activation key is: {text}");
        }
    }
}
