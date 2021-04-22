using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> productsPrice = new Dictionary<string, double>();
            Dictionary<string, double> productsQty = new Dictionary<string, double>();


            while (true)
            {
                string command = Console.ReadLine();
                if (command == "buy")
                {
                    break;
                }

                string[] commandArgs = command.Split().ToArray();

                string name = commandArgs[0];
                double price = double.Parse(commandArgs[1]);
                double qty = double.Parse(commandArgs[2]);

                if (!productsPrice.ContainsKey(name))
                {
                    productsPrice.Add(name, 0);
                    productsQty.Add(name, 0);

                }
                productsPrice[name] = price;
                productsQty[name] += qty;

            }

            foreach (var kvp in productsPrice)
            {
                string name = kvp.Key;
                double price = kvp.Value;
                double qty = productsQty[name];

                Console.WriteLine($"{name} -> {(price * qty):f2}");
            }
        }
    }
}
