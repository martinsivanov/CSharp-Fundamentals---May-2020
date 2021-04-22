using System;

namespace _05._Digits__Letters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string digit = string.Empty;
            string symbols = string.Empty;
            string letter = string.Empty;

            for (int i = 0; i < text.Length; i++)
            {
                char current = text[i];
                if (char.IsDigit(current) == true)
                {
                    digit += current;
                }
                else if (char.IsLetter(current) == true)
                {

                    letter += current;
                }
                else
                {
                    symbols += current;
                }

            }
            Console.WriteLine(digit);
            Console.WriteLine(letter);
            Console.WriteLine(symbols);
        }
    }
}
