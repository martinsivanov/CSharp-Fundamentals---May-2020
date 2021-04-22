using System;

namespace _02._English_Name_of_the_Last_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbersToText = { "zero",
                                       "one",
                                       "two",
                                       "three",
                                       "four",
                                       "five",
                                       "six",
                                       "seven",
                                       "eight",
                                       "nine"};
            int number = int.Parse(Console.ReadLine());
            int lastDigit = number % 10;
            Console.WriteLine(numbersToText[lastDigit]);
        }
    }
}
