using System;

namespace _05____Login_
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string correctPass = string.Empty;

            for (int i = username.Length - 1; i >= 0; i--)
            {
                correctPass += username[i];
            }
            bool isBlocked = true;
            for (int i = 1; i < 4; i++)
            {
                string password = Console.ReadLine();

                if (correctPass == password)
                {
                    isBlocked = false;
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                Console.WriteLine("Incorrect password. Try again.");

            }
            if (isBlocked)
            {
                Console.WriteLine($"User {username} blocked!");
            }
        }
    }
}
