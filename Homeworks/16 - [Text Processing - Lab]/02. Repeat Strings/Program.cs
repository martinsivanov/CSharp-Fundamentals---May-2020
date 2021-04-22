using System;
using System.Linq;

namespace _02._Repeat_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            string final = String.Empty;

            foreach (var word in arr)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    final += word;
                }

            }
            Console.WriteLine(final);
        }
    }
}
