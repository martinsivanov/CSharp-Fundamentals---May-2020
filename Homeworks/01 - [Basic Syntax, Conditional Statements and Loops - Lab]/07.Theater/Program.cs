using System;

namespace _07.Theater
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeDay = Console.ReadLine(); ;
            int age = int.Parse(Console.ReadLine());
            int sum = 0;

            if (typeDay == "Weekday")
            {
                if (age >= 0 && age <= 18)
                {
                    sum = 12;
                }
                else if (age > 18 && age <= 64)
                {
                    sum = 18;
                }
                else if (age > 64 && age <= 122 && age <= 1000)
                {
                    sum = 12;
                }
            }
            else if (typeDay == "Weekend")
            {
                if (age >= 0 && age <= 18)
                {
                    sum = 15;
                }
                else if (age > 18 && age <= 64)
                {
                    sum = 20;
                }
                else if (age > 64 && age <= 122)
                {
                    sum = 15;
                }
            }
            else if (typeDay == "Holiday")
            {
                if (age >= 0 && age <= 18)
                {
                    sum = 5;
                }
                else if (age > 18 && age <= 64)
                {
                    sum = 12;
                }
                else if (age > 64 && age <= 122)
                {
                    sum = 10;
                }
            }
            if (sum != 0)
            {
                Console.WriteLine($"{sum}$");
                
            }
            else
            {
                Console.WriteLine("Error!");
            }

        }
    }
}
