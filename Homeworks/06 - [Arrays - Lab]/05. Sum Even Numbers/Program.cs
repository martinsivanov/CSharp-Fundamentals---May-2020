using System;
using System.Linq;

namespace _05._Sum_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int evenSum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currNum = numbers[i];

                if (numbers[i] % 2 == 0)
                {
                    evenSum += currNum;
                }
            }
            Console.WriteLine(evenSum);
        }
    }
}
