using System;

namespace _01._Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int result = SmallestNum(num1, num2, num3);
            Console.WriteLine(result);
        }

        private static int SmallestNum(int num1, int num2, int num3)
        {
            int min1 = Math.Min(num1, num2);
            int smallest = Math.Min(min1, num3);

            return smallest;
        }
    }
}
