using System;

namespace _05._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int Sum = GetSum(num1, num2);
            int Substract = GetSubstract(Sum, num3);
            Console.WriteLine(Substract);

        }
        static int GetSum(int a, int b)
        {
            return a + b;
        }
        static int GetSubstract(int sum, int c)
        {
            return sum - c;
        }
    }
}
