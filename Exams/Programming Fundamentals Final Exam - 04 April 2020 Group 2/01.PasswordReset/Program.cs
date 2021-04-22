using System;
using System.Linq;

namespace _01.PasswordReset
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string input = Console.ReadLine();
            while (input != "Done")
            {
                string[] commands = input.Split().ToArray();
                string newText = String.Empty;
                if (commands.Contains("TakeOdd"))
                {

                    for (int i = 0; i < text.Length; i++)
                    {
                        if (i % 2 == 1)
                        {
                            newText += text[i];
                        }
                    }
                    text = newText;
                    Console.WriteLine(text);
                }
                if (commands.Contains("Cut"))
                {
                    int index = int.Parse(commands[1]);
                    int lenght = int.Parse(commands[2]);

                    text = text.Remove(index, lenght);
                    Console.WriteLine(text);

                }
                if (commands.Contains("Substitute"))
                {
                    string substring = commands[1];
                    string substitute = commands[2];

                    if (text.Contains(substring))
                    {
                        text = text.Replace(substring, substitute);
                        Console.WriteLine(text);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                }
                  
                input = Console.ReadLine();
            }

            Console.WriteLine($"Your password is: {text}");
        }
    }
}
