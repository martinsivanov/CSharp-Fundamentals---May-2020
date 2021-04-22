using System;
using System.Linq;

namespace _08._Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(new string[] { " ", "\t" }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            double sum = 0; ;
            double total = 0;

            for (int i = 0; i < words.Length; i++)
            {
                sum = 0;
                string current = words[i];
                char firstLetter = current[0];
                char lastLetter = current[current.Length - 1];
                double number = double.Parse(current.Substring(1, current.Length - 2));

                if (char.IsUpper(firstLetter))
                {
                    sum += number / (firstLetter - 'A' + 1);
                }
                else if (char.IsLower(firstLetter))
                {
                    sum += (number * (firstLetter - 'a' + 1));
                }

                if (char.IsUpper(lastLetter))
                {
                    sum -= (lastLetter - 'A' + 1);
                }
                else if (char.IsLower(lastLetter))
                {
                    sum += (lastLetter - 'a' + 1);
                }

                total += sum;
            }

            Console.WriteLine($"{total:f2}");
        }
    }
}
