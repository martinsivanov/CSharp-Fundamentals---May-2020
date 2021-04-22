using System;
using System.Text.RegularExpressions;

namespace _02._Fancy_Barcodes_Problem_Description
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^@#+(?=[A-Z])(?<name>[A-Za-z0-9]{6,})(?<=[A-Z])@#+$";

            int n = int.Parse(Console.ReadLine());
            string numbers = string.Empty;


            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                Match match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    string name = match.Groups["name"].Value;

                    for (int j = 0; j < name.Length; j++)
                    {
                        if (char.IsDigit(name[j]))
                        {
                            numbers += name[j];

                        }

                    }
                    if (numbers == string.Empty)
                    {
                        Console.WriteLine("Product group: 00");
                    }
                    else if (numbers == "0")
                    {
                        numbers = string.Empty;
                        Console.WriteLine("Product group: 0");
                    }
                    else
                    {
                        Console.WriteLine($"Product group: {numbers}");
                        numbers = string.Empty;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}
