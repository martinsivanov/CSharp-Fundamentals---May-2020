using System;

namespace _02____Division_
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int searchNum = 0;


            if (num % 10 == 0)
            {

                searchNum = 10;


            }
            else if (num % 7 == 0)
            {
                searchNum = 7;

            }
            else if (num % 6 == 0)
            {
                searchNum = 6;

            }
            else if (num % 3 == 0)
            {
                searchNum = 3;

            }
            else if (num % 2 == 0)
            {
                searchNum = 2;

            }
            if (searchNum != 0)
            {
                Console.WriteLine($"The number is divisible by {searchNum}");
            }
            else
            {
                Console.WriteLine("Not divisible");
            }
        }
    }
}
