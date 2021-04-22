using System;
using System.Linq;

namespace _04._Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] banWords = Console.ReadLine().Split(", ").ToArray();

            string text = Console.ReadLine();

            foreach (var banword in banWords)
            {

                if (text.Contains(banword))
                {
                    text = text.Replace(banword, new string('*', banword.Length));
                }

            }
            Console.WriteLine(text);
        }
    }
}
