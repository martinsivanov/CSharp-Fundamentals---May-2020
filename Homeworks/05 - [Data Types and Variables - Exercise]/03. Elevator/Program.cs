using System;

namespace _03._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            int course = 0;
            int temp = 0;
            course = numPeople / capacity;
            temp = numPeople % capacity;
            if (temp > 0)
            {
                course += 1;
            }
            Console.WriteLine(course);
        }
    }
}
