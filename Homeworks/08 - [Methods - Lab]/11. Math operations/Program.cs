using System;

namespace _11._Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            string sumbol = Console.ReadLine();
            int num2 = int.Parse(Console.ReadLine());

            int result = Calculate(num1, sumbol, num2);
            Console.WriteLine(result);

        }

        private static int Calculate(int num1, string sumbol, int num2)
        {
            int result = 0;

            if (sumbol == "+")
            {
                result = num1 + num2;
            }
            else if (sumbol == "-")
            {
                result = num1 - num2;
            }
            else if (sumbol == "*")
            {
                result = num1 * num2;
            }
            else if (sumbol == "/")
            {
                result = num1 / num2;
            }
            return result;
        }
    }
}
