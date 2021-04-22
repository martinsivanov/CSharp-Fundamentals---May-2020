using System;

namespace _10____Rage_Expenses_
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            float headsetPrice = float.Parse(Console.ReadLine());
            float mousePrice = float.Parse(Console.ReadLine());
            float keyboardPrice = float.Parse(Console.ReadLine());
            float displayPrice = float.Parse(Console.ReadLine());

            int trashedHeadsetTimes = 0;
            int trashedMouseTimes = 0;
            int trashedKeyboardTimes = 0;
            int trashedDisplayTimes = 0;

            for (int lostGame = 1; lostGame <= lostGamesCount; lostGame++)
            {
                if (lostGame % 2 == 0)
                {
                    trashedHeadsetTimes++;
                }
                if (lostGame >= 3 && lostGame % 3 == 0)
                {
                    trashedMouseTimes++;
                }
                if (lostGame % 3 == 0 && lostGame % 2 == 0)
                {
                    trashedKeyboardTimes++;
                    if (trashedKeyboardTimes % 2 == 0 && trashedKeyboardTimes > 0)
                    {
                        trashedDisplayTimes++;
                    }
                }

            }
            if (trashedDisplayTimes > 0)
            {
                double expenses = headsetPrice * trashedHeadsetTimes + mousePrice * trashedMouseTimes +
                    keyboardPrice * trashedKeyboardTimes + displayPrice * trashedDisplayTimes;
                Console.WriteLine($"Rage expenses: {expenses:f2} lv.");
            }
            else
            {
                double expenses = headsetPrice * trashedHeadsetTimes + mousePrice * trashedMouseTimes +
                    keyboardPrice * trashedKeyboardTimes;
                Console.WriteLine($"Rage expenses: {expenses:f2} lv.");
            }

        }
    }
}
