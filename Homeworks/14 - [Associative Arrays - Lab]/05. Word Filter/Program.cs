using System;
using System.Linq;

namespace _05._Word_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] words = Console.ReadLine().Split()
                .Where(n => n.Length % 2 == 0).ToArray();

            Console.Write(String.Join(Environment.NewLine, words));
        }
    }
}
