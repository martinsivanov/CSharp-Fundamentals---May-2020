using System;

namespace _02._Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());

            OutPut(input);
        }

        static void OutPut(double num)
        {
            if (num < 3 && num >= 2)
            {
                Console.WriteLine("Fail");
            }
            else if (num >= 3 && num < 3.50)
            {
                Console.WriteLine("Poor");
            }
            else if (num < 4.5 && num >= 3.5)
            {
                Console.WriteLine("Good");
            }
            else if (num < 5.50 && num >= 4.50)
            {
                Console.WriteLine("Very good");
            }
            else if (num <= 6 && num >= 5.50)
            {
                Console.WriteLine("Excellent");
            }
        }
    }
}
