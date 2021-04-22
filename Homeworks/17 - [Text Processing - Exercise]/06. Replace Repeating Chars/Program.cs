using System;

namespace _06._Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            for (int i = 0; i < text.Length; i++)
            {
                char current = text[i];

                for (int j = i + 1; j < text.Length; j++)
                {
                    char nextCurrent = text[j];

                    if (current == nextCurrent)
                    {
                        text = text.Remove(j, 1);
                        j -= 1;
                    }
                    else
                    {
                        break;
                    }
                }

            }
            Console.WriteLine(text);
        }
    }
}
