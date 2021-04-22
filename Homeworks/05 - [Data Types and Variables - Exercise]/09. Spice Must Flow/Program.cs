using System;

namespace _09._Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int consume = startingYield;
            int consumeSum = 0;
            int days = 0;
            if (startingYield < 100)
            {
                Console.WriteLine(days);
                Console.WriteLine(consumeSum);
                return;
            }
            for (int i = 1; i <= 2147483647; i++)
            {
                days = i;
                startingYield -= 10;
                consume -= 26;
                consumeSum += consume;
                consume = startingYield;


                if (startingYield < 100)
                {
                    days = i;
                    consumeSum -= 26;
                    break;

                }
            }
            Console.WriteLine(days);
            Console.WriteLine(consumeSum);
        }
    }
}
