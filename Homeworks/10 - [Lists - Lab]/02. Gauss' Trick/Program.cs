using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Gauss__Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                  .Split()
                  .Select(int.Parse)
                  .ToList();

            // first + last, first + 1 + last - 1, first + 2 + last - 2, … first + n, last - n.
            int originalLenght = numbers.Count;
            for (int i = 0; i < originalLenght / 2; i++)
            {

                numbers[i] += numbers[numbers.Count - 1];
                numbers.RemoveAt(numbers.Count - 1);

            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
