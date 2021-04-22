using System;
using System.Linq;

namespace _08._Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int number = int.Parse(Console.ReadLine());
            int first = 0;
            int second = 0;

            for (int curr = 0; curr < arr.Length; curr++)
            {
                int currElement = arr[curr];
                int sum = 0;
                for (int i = curr + 1; i < arr.Length; i++)
                {
                    int currI = arr[i];

                    sum = currElement + currI;
                    if (sum == number)
                    {
                        first = currElement;
                        second = currI;
                        Console.WriteLine(String.Join(" ", first, second));

                    }
                }

            }
        }
    }
}
