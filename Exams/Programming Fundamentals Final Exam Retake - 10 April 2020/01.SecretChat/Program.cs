using System;
using System.Linq;

namespace _01.SecretChat
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string input = Console.ReadLine();
            bool isDone = false;
            while (input != "Reveal")
            {
                string[] command = input.Split(":|:");

                if (command.Contains("InsertSpace"))
                {
                    int index = int.Parse(command[1]);

                    text = text.Insert(index, " ");
                    Console.WriteLine(text);
                }
                if (command.Contains("Reverse"))
                {
                    string substring = command[1];

                    if (text.Contains(substring))
                    {
                        if (isDone == false)
                        {
                            int startIndex = text.IndexOf(substring[0]);
                            text = text.Remove(startIndex, substring.Length);
                            string reversedSubstring = null;
                            for (int i = substring.Length - 1; i >= 0; i--)
                            {
                                reversedSubstring += substring[i];
                            }

                            text = text.Insert(text.Length, reversedSubstring);
                            isDone = true;
                            Console.WriteLine(text);
                        } 
                        
                        

                    }
                    else
                    {
                        Console.WriteLine("error");
                    }

                }
                if (command.Contains("ChangeAll"))
                {
                    string substring = command[1];
                    string replacement = command[2];

                    text = text.Replace(substring, replacement);
                    Console.WriteLine(text);
                }



                input = Console.ReadLine();
            }

            Console.WriteLine($"You have a new text message: {text}");
        }
    }
}
