using System;

namespace _01.DisneyLand
{
    class Program
    {
        static void Main(string[] args)
        {
            double jorneyCost = double.Parse(Console.ReadLine());
            int numberOfMouths = int.Parse(Console.ReadLine());

            double EndOfEachMouth = jorneyCost * 0.25;
            double moneySave = 0;

            for (int i = 1; i <= numberOfMouths; i++)
            {
                if (i % 2 == 1 && i != 1)
                {
                    moneySave -= moneySave * 0.16;
                }
                if (i % 4 == 0)
                {
                    moneySave += moneySave * 0.25;
                }
                EndOfEachMouth = jorneyCost * 0.25;
                moneySave += EndOfEachMouth;

            }
            if (jorneyCost > moneySave)
            {
                double moneyleft = jorneyCost - moneySave;
                Console.WriteLine($"Sorry. You need {moneyleft:f2}lv. more.");
            }
            else
            {
                double moneyLeft = moneySave - jorneyCost;
                Console.WriteLine($"Bravo! You can go to Disneyland and you will have {moneyLeft:f2}lv. for souvenirs.");
            }
        }
    }
}
