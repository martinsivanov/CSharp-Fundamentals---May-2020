using System;

namespace _05._Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine(); // 9999
            int second = int.Parse(Console.ReadLine()); // 9
            string result = null;

            while (first[0] == '0')
            {
                first = first.Substring(1);
            }


            if (second == 0)
            {
                Console.WriteLine(0);
                return;
            }



            int sum = 0;
            int temp = 0;
            for (int i = first.Length - 1; i >= 0; i--)
            {
                int current = int.Parse(first[i].ToString());

                sum = current * second + temp;
                if (sum > 9)
                {
                    temp = sum / 10;
                    sum %= 10;
                }
                else
                {
                    temp = 0;
                }

                result += sum.ToString();
            }
            if (temp != 0)
            {
                result += temp.ToString();
            }

            //reverse:
            string finalResult = null;
            for (int i = result.Length - 1; i >= 0; i--)
            {
                finalResult += result[i];
            }

            Console.WriteLine(finalResult);
        }
    }
}
