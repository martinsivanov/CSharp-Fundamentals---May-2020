using System;
using System.Linq;

namespace _05._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                           .Split()
                           .Select(int.Parse)
                           .ToArray();

            string result = "";
            for (int i = 0; i < arr.Length; i++)
            {
                bool isTopInteger = true;
                int currI = arr[i];

                for (int index = i + 1; index < arr.Length; index++)
                {
                    int currIndex = arr[index];

                    if (currI <= currIndex)
                    {
                        isTopInteger = false;
                        break;
                    }

                }
                if (isTopInteger == true)
                {
                    result += currI + " ";
                }

            }
            Console.WriteLine(result);
        }
    }
}
