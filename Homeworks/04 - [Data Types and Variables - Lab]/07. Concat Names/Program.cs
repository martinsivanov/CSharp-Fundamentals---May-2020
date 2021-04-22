using System;

namespace _07._Concat_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string name1 = Console.ReadLine();
            string symbol = Console.ReadLine();

            Console.WriteLine($"{name}{symbol}{name1}");
        }
    }
}
