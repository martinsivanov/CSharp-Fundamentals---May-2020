using System;

namespace _01.BiscuitFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int amountOfBiscuits = int.Parse(Console.ReadLine()); // worker produce a day 
            int countWorkers = int.Parse(Console.ReadLine()); // in factory
            int biscuitsProducedFor30days = int.Parse(Console.ReadLine());
            double totalFor30 = 0;
            double forOneday = 0;
            double percen = 0;
            for (int i = 1; i <= 30; i++)
            {
                if (i % 3 == 0)
                {
                    forOneday += Math.Floor(amountOfBiscuits * countWorkers * 0.75);
                     
                }
                else
                {
                    totalFor30 += amountOfBiscuits * countWorkers;
                }
                
            }
            totalFor30 += forOneday;

            Console.WriteLine($"You have produced {totalFor30} biscuits for the past month.");
            if (totalFor30 > biscuitsProducedFor30days)
            {
                double need = (int)totalFor30 - biscuitsProducedFor30days;
                percen = need / biscuitsProducedFor30days * 100;
                Console.WriteLine($"You produce {percen:f2} percent more biscuits.");
            }
            else
            {
                double need =   biscuitsProducedFor30days - totalFor30;
                percen = need / biscuitsProducedFor30days * 100;
                Console.WriteLine($"You produce {percen:f2} percent less biscuits.");
            }

        }
    }
}
