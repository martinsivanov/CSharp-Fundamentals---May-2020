using System;
using System.Linq;

namespace _02._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split().ToArray();
            string[] arr2 = Console.ReadLine().Split().ToArray();

            foreach (var word1 in arr1)
            {
                foreach (var word2 in arr2)
                {
                    if (word1 == word2)
                    {
                        Console.Write(word2 + " ");
                    }
                }
            }
        }
    }
}
