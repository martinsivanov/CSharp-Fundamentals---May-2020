using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            string pattern = @">>(?<name>[A-Z]+[a-z]*)<<(?<price>\d+\.*\d+)!(?<qty>\d+)";
            double totalMoney = 0;
            string input = Console.ReadLine();

            while (input != "Purchase")
            {

                var collection = Regex.Matches(input, pattern);

                foreach (Match name in collection)
                {
                    if (name.Success)
                    {
                        var forture = name.Groups["name"].Value;
                        var price = name.Groups["price"].Value;
                        var qty = name.Groups["qty"].Value;
                        totalMoney += double.Parse(price) * double.Parse(qty);
                        list.Add(forture);
                    }
                    else
                    {
                        Console.WriteLine($"Total money spend: {totalMoney:f2}");
                        return;
                    }


                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Bought furniture:");
            if (list.Count > 0)
            {
                Console.WriteLine($"{string.Join(Environment.NewLine, list)}");
            }
            Console.WriteLine($"Total money spend: {totalMoney:f2}");
            Console.WriteLine($"test");
            Console.WriteLine($"tes2");
        }
    }
}
