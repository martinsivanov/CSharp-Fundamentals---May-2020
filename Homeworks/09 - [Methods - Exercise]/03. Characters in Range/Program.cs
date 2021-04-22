using System;

namespace _03._Characters_in_Range
{
    class Program
    {

        static void Main(string[] args)
        {
            char firstLetter = char.Parse(Console.ReadLine());
            char SecondLetter = char.Parse(Console.ReadLine());

            result(firstLetter, SecondLetter);
        }

        private static void result(char firstLetter, char secondLetter)
        {
            int start = Math.Min(firstLetter, secondLetter);
            int end = Math.Max(firstLetter, secondLetter);

            for (int i = start + 1; i < end; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}
