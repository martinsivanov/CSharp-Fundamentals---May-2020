using System;
using System.Linq;

namespace Nikulden_s_Charity
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string input = Console.ReadLine();
            while (input != "Finish")
            {
                string[] commands = input.Split().ToArray();
                if (commands.Contains("Replace"))
                {
                    char currentChar = char.Parse(commands[1]);
                    char newChar = char.Parse(commands[2]);


                    text = text.Replace(currentChar, newChar);
                    Console.WriteLine(text);
                }
                else if (commands.Contains("Cut"))
                {
                    int startIndex = int.Parse(commands[1]);
                    int endIndex = int.Parse(commands[2]);

                    if (startIndex > 0 && startIndex < text.Length && endIndex > 0 && endIndex < text.Length)
                    {

                        text = text.Remove(startIndex, endIndex);
                        Console.WriteLine(text);
                    }
                    else
                    {
                        Console.WriteLine("Invalid indexes!");
                    }


                }
                else if (commands.Contains("Make"))
                {
                    if (commands[1] == "Upper")
                    {
                        text = text.ToUpper();
                        Console.WriteLine(text);
                    }
                    else if (commands[1] == "Lower")
                    {
                        text = text.ToLower();
                        Console.WriteLine(text);
                    }
                }
                else if (commands.Contains("Check"))
                {
                    string strings = commands[1];
                    if (text.Contains(strings))
                    {
                        Console.WriteLine($"Message contains {strings}");
                    }
                    else
                    {
                        Console.WriteLine($"Message doesn't contain {strings}");
                    }
                }
                else if (commands.Contains("Sum"))
                {
                    int startIndex = int.Parse(commands[1]);
                    int endIndex = int.Parse(commands[2]);

                    if (startIndex > 0 && startIndex < text.Length && endIndex > 0 && endIndex < text.Length)
                    {
                        string substring = text.Substring(startIndex, endIndex);
                        int value = 0;
                        for (int i = 0; i < substring.Length; i++)
                        {
                            char current = substring[i];
                            value += (int)(current);
                        }
                        Console.WriteLine(value);
                    }
                    else
                    {
                        Console.WriteLine("Invalid indexes!");
                    }


                }

                input = Console.ReadLine();
            }
        }
    }
}
