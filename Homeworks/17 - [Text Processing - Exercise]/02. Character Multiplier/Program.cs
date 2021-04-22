using System;
using System.Linq;

namespace _02._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            string first = input[0];
            string second = input[1];

            string result = CharacterMultiplier(first, second);
            Console.WriteLine(result);
        }

        private static string CharacterMultiplier(string first, string second)
        {
            int sum = 0;
            string result = null;
            string longest = string.Empty;
            string shortest = string.Empty;
            int a = 0;
            int b = 0;
            if (first.Length > second.Length)
            {
                longest = first;
                shortest = second;
            }
            else
            {
                longest = second;
                shortest = first;
            }

            for (int i = 0; i < shortest.Length; i++)
            {
                a = first[i];
                b = second[i];
                sum += (int)(shortest[i] * longest[i]);
            }
            if (longest.Length > shortest.Length)
            {
                for (int i = shortest.Length; i < longest.Length; i++)
                {
                    sum += longest[i];
                }
            }


            result = sum.ToString();

            return result;
        }
    }
}
