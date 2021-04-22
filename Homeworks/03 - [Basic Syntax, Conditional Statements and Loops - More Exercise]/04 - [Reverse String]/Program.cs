using System;

namespace _04____Reverse_String_
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string reversedStr = string.Empty;

            for (int i = str.Length - 1; i >= 0; i--)
            {
                reversedStr += str[i];
            }
            Console.WriteLine(reversedStr);
        }
    }
}
