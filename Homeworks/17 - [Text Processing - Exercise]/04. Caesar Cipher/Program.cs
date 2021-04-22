using System;

namespace _04._Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string temp = string.Empty;
            for (int i = 0; i < text.Length; i++)
            {
                int current = text[i] + 3;
                temp += (char)current;

            }
            Console.WriteLine(temp);
        }
    }
}
