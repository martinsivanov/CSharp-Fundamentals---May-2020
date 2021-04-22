using System;

namespace _09._Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            bool isPalidrome = false;

            while (command != "END")
            {
                Console.WriteLine(PalidromeCheck(command).ToString().ToLower());
                command = Console.ReadLine();

            }
        }
        static bool PalidromeCheck(string command)
        {
            string reverse = "";

            for (int i = command.Length - 1; i >= 0; i--)
            {
                char symbol = command[i];
                reverse += symbol;
            }
            if (reverse == command)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
