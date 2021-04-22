using System;

namespace _10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());


            for (int i = 1; i <= num; i++)
            {
                if (SumOfDigitsDivisiblyByEight(i) && OddDigit(i))
                {
                    Console.WriteLine(i);
                }
            }


        }

        static bool OddDigit(int num)
        {
            int counter = 0;
            while (num > 0)
            {
                if ((num % 10) % 2 == 1)
                {
                    counter++;
                }
                num /= 10;
            }
            if (counter >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool SumOfDigitsDivisiblyByEight(int num)
        {
            int sum = 0;
            while (num > 0)
            {

                sum += num % 10;
                num /= 10;
            }
            if (sum % 8 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
