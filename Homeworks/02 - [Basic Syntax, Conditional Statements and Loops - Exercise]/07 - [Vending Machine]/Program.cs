using System;

namespace _07____Vending_Machine_
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double sumCoins = 0;
            double productPrice = 0;
            while (command != "Start")
            {
                double coins = double.Parse(command);

                if (coins == 0.1 || coins == 0.2 || coins == 0.5 || coins == 1.0 || coins == 2.0)
                {
                    sumCoins += coins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }
                command = Console.ReadLine();
            }
            double money = sumCoins;
            string product = Console.ReadLine();
            while (product != "End")
            {

                if (product == "Nuts")
                {
                    productPrice = 2.0;
                    if (sumCoins >= productPrice)
                    {
                        sumCoins -= productPrice;
                        Console.WriteLine("Purchased nuts");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (product == "Water")
                {
                    productPrice = 0.7;
                    if (sumCoins >= productPrice)
                    {
                        sumCoins -= productPrice;
                        Console.WriteLine("Purchased water");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (product == "Crisps")
                {
                    productPrice = 1.5;
                    if (sumCoins >= productPrice)
                    {
                        sumCoins -= productPrice;
                        Console.WriteLine("Purchased crisps");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (product == "Soda")
                {
                    productPrice = 0.8;
                    if (sumCoins >= productPrice)
                    {
                        sumCoins -= productPrice;
                        Console.WriteLine("Purchased soda");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (product == "Coke")
                {
                    productPrice = 1.0;
                    if (sumCoins >= productPrice)
                    {
                        sumCoins -= productPrice;
                        Console.WriteLine("Purchased coke");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
                product = Console.ReadLine();
            }
            if (product == "End")
            {

                Console.WriteLine($"Change: {sumCoins:f2}");
            }
        }
    }
}
