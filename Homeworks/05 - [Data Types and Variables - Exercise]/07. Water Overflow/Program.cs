using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int capacityTank = 255;
            int sumQuantities = 0;
            int tempQuantities = 0;
            for (int i = 1; i <= n; i++)
            {
                int quantities = int.Parse(Console.ReadLine());


                sumQuantities += quantities;
                if (sumQuantities > 255)
                {
                    sumQuantities -= quantities;
                    Console.WriteLine("Insufficient capacity!");

                }

            }
            Console.WriteLine(sumQuantities);
        }
    }
}
