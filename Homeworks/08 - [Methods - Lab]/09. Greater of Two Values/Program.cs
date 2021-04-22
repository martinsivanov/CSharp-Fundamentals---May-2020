using System;

namespace _09._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            if (type == "int")
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                int sum = GetInt(first, second);
                Console.WriteLine(sum);
            }
            else if (type == "char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());
                char max = getMax(first, second);
                Console.WriteLine(max);
            }
            else if (type == "string")
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();
                string max = GetMax(first, second);
                Console.WriteLine(max);
            }
        }

        private static string GetMax(string first, string second)
        {

            if (second.CompareTo(first) >= 0)
            {
                return second;
            }
            else
            {
                return first;
            }

        }

        private static char getMax(char first, char second)
        {

            if (first > second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }

        private static int GetInt(int first, int second)
        {
            if (first > second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
    }
}
