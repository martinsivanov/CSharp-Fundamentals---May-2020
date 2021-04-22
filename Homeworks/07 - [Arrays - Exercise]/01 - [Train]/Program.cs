using System;

namespace _01____Train_
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            int[] train = new int[count];
            int sum = 0;
            for (int i = 0; i < train.Length; i++)
            {
                train[i] = int.Parse(Console.ReadLine());
                sum += train[i];
            }
            Console.WriteLine(String.Join(" ", train));
            Console.WriteLine(sum);
        }
    }
}
