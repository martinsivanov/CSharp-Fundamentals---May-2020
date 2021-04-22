using System;

namespace _01____Sort_Numbers_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[3];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(array); Array.Reverse(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
