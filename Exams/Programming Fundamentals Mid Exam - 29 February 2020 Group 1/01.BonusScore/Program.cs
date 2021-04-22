using System;

namespace _01.BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {

            int countStudents = int.Parse(Console.ReadLine());
            int countLectures = int.Parse(Console.ReadLine());
            int initialBonus = int.Parse(Console.ReadLine());
            double totalBonus = 0;
            double maxBonus = 0;
            int MaxLectures = 0; ;
            for (int i = 1; i <= countStudents; i++)
            {
                int attendances = int.Parse(Console.ReadLine());
                totalBonus = attendances * 1.0 / countLectures * (5 + initialBonus);
                if (totalBonus > maxBonus)
                {
                    MaxLectures = attendances;
                    maxBonus = totalBonus;
                }


            }
            Console.WriteLine($"Max Bonus: {Math.Ceiling(maxBonus)}.");
            Console.WriteLine($"The student has attended {MaxLectures} lectures.");

        }

    }

}