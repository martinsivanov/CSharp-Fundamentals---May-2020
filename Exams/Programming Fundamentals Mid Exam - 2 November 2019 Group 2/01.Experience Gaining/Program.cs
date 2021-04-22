using System;

namespace _01.Experience_Gaining
{
    class Program
    {
        static void Main(string[] args)
        {
            double needExp = double.Parse(Console.ReadLine()); // 500   
            int countBattles = int.Parse(Console.ReadLine()); // 5
            double totalExp = 0;
            int battles = 0;
            for (int i = 1; i <= countBattles; i++)
            {
                battles++;
                double expPerBattle = double.Parse(Console.ReadLine());
                if (i % 3 == 0)
                {
                    expPerBattle += expPerBattle * 0.15;
                }
                if (i % 5 == 0)
                {
                    expPerBattle -= expPerBattle * 0.10;

                }

                totalExp += expPerBattle;
                if (totalExp >= needExp)
                {
                    break;
                }
            }
            if (totalExp >= needExp)
            {
                Console.WriteLine($"Player successfully collected his needed experience for {battles} battles.");
            }
            else
            {
                double need = needExp - totalExp;
                Console.WriteLine($"Player was not able to collect the needed experience, {need:f2} more needed.");
            }

        }
    }
}
