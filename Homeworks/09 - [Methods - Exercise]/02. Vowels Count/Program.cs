using System;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            int counts = VowelsCount(word);
            Console.WriteLine(counts);


        }
        static int VowelsCount(string word)
        {
            int count = 0;


            for (int i = 0; i < word.Length; i++)
            {
                char letter = word[i];

                if (letter == 'i' || letter == 'a' || letter == 'o' || letter == 'u' || letter == 'y' || letter == 'e' ||
                    letter == 'I' || letter == 'A' || letter == 'O' || letter == 'U' || letter == 'Y' || letter == 'E')
                {
                    count++;
                }
            }
            return count;
        }
    }
}
