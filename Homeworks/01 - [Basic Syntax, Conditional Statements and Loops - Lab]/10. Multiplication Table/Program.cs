using System;

namespace _10._Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int theInteger = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                sum = theInteger * i;
                Console.WriteLine($"{theInteger} X {i} = {sum}");
            }
        }
    }
}
