using System;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal num1 = decimal.Parse(Console.ReadLine());
            decimal num2 = decimal.Parse(Console.ReadLine());

            decimal result = Factorial(num1, num2);
            Console.WriteLine($"{result:f2}");

        }
        static decimal Factorial(decimal num1, decimal num2)
        {
            decimal temp = 1;
            decimal temp2 = 1;
            for (int i = 1; i <= num1; i++)
            {
                temp *= i;
            }
            for (int i = 1; i <= num2; i++)
            {
                temp2 *= i;
            }

            return temp / temp2;


        }
    }
}
