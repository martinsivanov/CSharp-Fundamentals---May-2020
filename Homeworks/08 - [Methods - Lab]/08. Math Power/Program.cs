using System;

namespace _08._Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = int.Parse(Console.ReadLine());
            double count = int.Parse(Console.ReadLine());

            double result = GetResult(num, count);
            Console.WriteLine(result);

        }

        private static double GetResult(double num, double count)
        {
            double result = 1;
            for (double i = 0; i < count; i++)
            {
                result *= num;
            }
            return result;
        }
    }
}
