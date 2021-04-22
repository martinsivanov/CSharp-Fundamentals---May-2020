using System;
using System.Linq;

namespace _04._Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split().ToArray();
            int count = int.Parse(Console.ReadLine());
            for (int c = 0; c < count; c++)
            {
                string temp = arr[0];

                for (int i = 0; i < arr.Length - 1; i++)
                {
                    arr[i] = arr[i + 1];

                }
                arr[arr.Length - 1] = temp;

            }
            Console.WriteLine(String.Join(" ", arr));
        }
    }
}
