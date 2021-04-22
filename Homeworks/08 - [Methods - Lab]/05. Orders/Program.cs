using System;

namespace _05._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            if (command == "coffee")
            {
                double price = 1.50;
                double total = SumPrice(quantity, price);
                Console.WriteLine($"{total:f2}");
            }
            else if (command == "water")
            {
                double price = 1;
                double total = SumPrice(quantity, price);
                Console.WriteLine($"{total:f2}");
            }
            else if (command == "coke")
            {
                double price = 1.40;
                double total = SumPrice(quantity, price);
                Console.WriteLine($"{total:f2}");
            }
            else if (command == "snacks")
            {
                double price = 2.0;
                double total = SumPrice(quantity, price);
                Console.WriteLine($"{total:f2}");
            }
        }

        static double SumPrice(double n, double price)
        {
            double totalPrice = price * n;
            return totalPrice;
        }
    }
}
