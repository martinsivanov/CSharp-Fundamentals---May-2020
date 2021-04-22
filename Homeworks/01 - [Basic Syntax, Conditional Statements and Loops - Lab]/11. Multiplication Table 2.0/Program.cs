using System;

namespace _10._Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine()); // 5 
            int num2 = int.Parse(Console.ReadLine()); // 1
            int sum = 0;
            if (num2 > 10)
            {
                Console.WriteLine(($"{num1} X {num2} = {num1 * num2}"));
            }
            for (int i = num2; num2 <= 10; num2++)
            {
                sum = num1 * num2;
                Console.WriteLine($"{num1} X {num2} = {sum}");
            }
            
        }
    }
}
