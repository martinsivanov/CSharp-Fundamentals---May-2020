using System;

namespace _10____Poke_Mon_
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());

            int pokedTargetsCounter = 0;
            double equality = pokePower / 2;

            while (pokePower >= distance)
            {
                pokePower -= distance;
                pokedTargetsCounter++;

                if ((pokePower == equality) && exhaustionFactor > 0)
                {
                    pokePower /= exhaustionFactor;
                }
            }
            Console.WriteLine(pokePower);
            Console.WriteLine(pokedTargetsCounter);
        }
    }
}
