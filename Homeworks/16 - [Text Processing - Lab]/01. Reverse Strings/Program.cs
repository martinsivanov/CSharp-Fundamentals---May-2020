using System;

namespace _01._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string reversedText = String.Empty;

            while (text != "end")
            {
                for (int i = text.Length - 1; i >= 0; i--)
                {
                    reversedText += text[i];
                }

                Console.WriteLine($"{text} = {reversedText}");
                reversedText = string.Empty;
                text = Console.ReadLine();
            }

        }
    }
}
