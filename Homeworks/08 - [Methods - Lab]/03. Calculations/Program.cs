using System;

namespace _03._Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (command == "add")
            {
                Add(a, b);
            }
            else if (command == "multiply")
            {
                multiply(a, b);
            }
            else if (command == "subtract")
            {
                subtract(a, b);
            }
            else if (command == "divide")
            {
                divide(a, b);
            }
        }

        private static void divide(int x, int y)
        {
            Console.WriteLine(x / y);
        }

        private static void subtract(int asd, int dsa)
        {
            Console.WriteLine(asd - dsa);
        }

        private static void multiply(int num3, int num4)
        {
            Console.WriteLine(num3 * num4);
        }

        private static void Add(int num1, int num2)
        {
            Console.WriteLine(num1 + num2);
        }
    }
}
