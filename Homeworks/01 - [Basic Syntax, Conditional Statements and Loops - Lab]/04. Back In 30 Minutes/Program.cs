using System;

namespace _04._Back_In_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine()); // 1
            int minutes = int.Parse(Console.ReadLine()); // 46

            minutes += 30;
            if (minutes > 59)
            {
                hour++;
                minutes -= 60;
            }
            else
            {

            }
            if (hour > 23)
            {
                hour = hour - 24;
            }
            else
            {

            }
            Console.WriteLine($"{hour}:{minutes:d2}");
        }
    }
}
