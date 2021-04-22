using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int bestCount = 0;

            int bestIndex = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int counter = 1;
                int currentElement = arr[i];
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (currentElement == arr[j])
                    {
                        counter++;
                    }
                    else
                    {
                        break;
                    }

                }
                if (counter > bestCount)
                {
                    bestCount = counter;
                    bestIndex = i;
                }
            }
            string result = "";
            for (int i = 0; i < bestCount; i++)
            {
                result += arr[bestIndex] + " ";
            }
            Console.WriteLine(result);
        }
    }
}
