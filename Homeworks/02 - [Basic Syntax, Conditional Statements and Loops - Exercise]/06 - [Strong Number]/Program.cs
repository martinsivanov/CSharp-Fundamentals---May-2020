using System;

namespace _06____Strong_Number_
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int tempnum = num;
            int facturialsum = 0;
            while (tempnum > 0)
            {
                int digit = tempnum % 10;
                tempnum /= 10;
                int res = 1;

                for (int i = 1; i <= digit; i++)
                {
                    res *= i;

                }
                facturialsum += res;

            }
            if (facturialsum == num)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
