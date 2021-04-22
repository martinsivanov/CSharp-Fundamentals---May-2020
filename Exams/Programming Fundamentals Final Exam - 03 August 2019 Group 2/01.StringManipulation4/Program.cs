using System;
using System.Linq;

namespace _01.StringManipulation4
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = Console.ReadLine();
            string input = Console.ReadLine();

            while (input != "Done")
            {
                string[] commands = input.Split();

                if (commands.Contains("Change"))
                {
                    string letter = commands[1];
                    string replacement = commands[2];
                    text = text.Replace(letter, replacement);
                    Console.WriteLine(text);

                }
                else if (commands.Contains("Includes"))
                {
                    string substing = commands[1];
                    if (text.Contains(substing))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (commands.Contains("End")) // KEEP IN MIND!!
                {
                    string substring = commands[1];
                    int index = text.LastIndexOf(substring);
                    if (index + substring.Length - 1 == text.Length - 1)
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }

                }
                else if (commands.Contains("Uppercase"))
                {
                    text = text.ToUpper();
                    Console.WriteLine(text);
                }
                else if (commands.Contains("FindIndex"))
                {
                    char letter = char.Parse(commands[1]);
                    int index = text.IndexOf(letter);
                    Console.WriteLine(index);
                }
                else if (commands.Contains("Cut"))
                {
                    int startIndex = int.Parse(commands[1]);
                    int lenght = int.Parse(commands[2]);

                     text = text.Substring(startIndex, lenght);
                    Console.WriteLine(text);
                }


                input = Console.ReadLine();
            }
        }
    }
}
