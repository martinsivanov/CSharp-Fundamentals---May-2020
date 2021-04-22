using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split().ToList();
            Random rnd = new Random();

            for (int pos1 = 0; pos1 < list.Count; pos1++)
            {
                int pos2 = rnd.Next(list.Count);
                string temp = list[pos1];
                list[pos1] = list[pos2];
                list[pos2] = temp;

            }
            Console.WriteLine(String.Join(Environment.NewLine, list));
        }
    }
}
