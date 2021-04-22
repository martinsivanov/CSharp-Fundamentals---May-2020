using System;
using System.Linq;

namespace _07._Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                int currNum = arr1[i];
                int currNum2 = arr2[i];


                if (currNum != currNum2)
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    return;
                }
                else
                {
                    sum += currNum;
                }
            }

            Console.WriteLine($"Arrays are identical. Sum: {sum}");
        }
    }
}
