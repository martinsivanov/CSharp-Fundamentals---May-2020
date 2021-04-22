using System;

namespace _07._Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            string outPut = GetOutput(word, count);
            Console.WriteLine(outPut);
        }

        private static string GetOutput(string word, int count)
        {
            string result = "";
            for (int i = 0; i < count; i++)
            {
                result += word;
            }
            return result;
        }
    }
}
