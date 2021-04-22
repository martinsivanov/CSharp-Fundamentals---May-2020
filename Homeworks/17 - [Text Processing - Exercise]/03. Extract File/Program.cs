using System;
using System.Linq;

namespace _03._Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split("\\").ToArray();
            string newText = text[text.Length - 1];

            string[] splited = newText.Split(".").ToArray();

            Console.WriteLine($"File name: {splited[0]}");
            Console.WriteLine($"File extension: {splited[1]}");
        }
    }
}
