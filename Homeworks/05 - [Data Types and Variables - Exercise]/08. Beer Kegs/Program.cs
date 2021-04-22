using System;

namespace _08._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double temp = double.MinValue;
            string tempString = "";
            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                float radios = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                double volume = Math.PI * Math.Pow(radios, 2) * height;
                if (volume > temp)
                {
                    temp = volume;
                    tempString = model;
                }

            }
            Console.WriteLine(tempString);
        }
    }
}
