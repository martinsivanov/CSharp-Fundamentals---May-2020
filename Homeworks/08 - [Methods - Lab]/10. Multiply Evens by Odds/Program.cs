using System;

namespace _10._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Math.Abs(int.Parse(Console.ReadLine()));

            int result = FindResult(num);

            Console.WriteLine(result);
        }

        private static int FindResult(int num)
        {
            int result = FindEvevSum(num) * FindOddSum(num);
            return result;
        }

        private static int FindOddSum(int num)
        {
            int OddSum = 0;
            while (num > 0)
            {
                int digit = num % 10;
                if (digit % 2 != 0)
                {
                    OddSum += digit;
                }
                num /= 10;
            }
            return OddSum;
        }

        private static int FindEvevSum(int num)
        {
            int EvenSum = 0;
            while (num > 0)
            {

                int digit = num % 10;

                if (digit % 2 == 0)
                {
                    EvenSum += digit;

                }
                num /= 10;

            }
            return EvenSum;
        }
    }
}
