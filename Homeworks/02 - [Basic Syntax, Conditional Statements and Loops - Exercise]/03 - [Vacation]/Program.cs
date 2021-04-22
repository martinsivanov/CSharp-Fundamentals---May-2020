using System;

namespace _03____Vacation_
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string typePeople = Console.ReadLine();
            string typeDay = Console.ReadLine();

            double price = 0;

            if (typePeople == "Students")
            {
                if (typeDay == "Friday")
                {
                    price = 8.45;
                    price = price * people;
                    if (people >= 30)
                    {
                        price -= price * 0.15;
                    }
                }
                else if (typeDay == "Saturday")
                {
                    price = 9.80;
                    price = price * people;
                    if (people >= 30)
                    {
                        price -= price * 0.15;
                    }
                }
                else if (typeDay == "Sunday")
                {
                    price = 10.46;
                    price = price * people;
                    if (people >= 30)
                    {
                        price -= price * 0.15;
                    }
                }
            }
            else if (typePeople == "Business")

            {
                if (people >= 100)
                {
                    people -= 10;
                }
                if (typeDay == "Friday")
                {
                    price = 10.90;
                    price = price * people;
                }
                else if (typeDay == "Saturday")
                {
                    price = 15.60;
                    price = price * people;
                }
                else if (typeDay == "Sunday")
                {
                    price = 16;
                    price = price * people;
                }
            }
            else if (typePeople == "Regular")
            {

                if (typeDay == "Friday")
                {
                    price = 15;
                    price = price * people;

                    if (people >= 10 && people <= 20)
                    {
                        price -= price * 0.05;
                    }
                }
                else if (typeDay == "Saturday")
                {
                    price = 20;
                    price = price * people;
                    if (people >= 10 && people <= 20)
                    {
                        price -= price * 0.05;
                    }
                }
                else if (typeDay == "Sunday")
                {
                    price = 22.50;
                    price = price * people;
                    if (people >= 10 && people <= 20)
                    {
                        price -= price * 0.05;
                    }
                }
            }

            Console.WriteLine($"Total price: {price:f2}");
        }
    }
}
