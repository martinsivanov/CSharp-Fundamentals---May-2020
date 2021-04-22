using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> playerOne = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> playerTwo = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                // 20 30 40 50
                //  10 20 30 40

                if (playerOne[0] > playerTwo[0])
                {
                    playerOne.Add(playerOne[0]);
                    playerOne.Add(playerTwo[0]);
                    playerOne.RemoveAt(0);
                    playerTwo.RemoveAt(0);
                }
                else if (playerOne[0] < playerTwo[0])
                {
                    playerTwo.Add(playerTwo[0]);
                    playerTwo.Add(playerOne[0]);
                    playerTwo.RemoveAt(0);
                    playerOne.RemoveAt(0);
                }
                else if (playerOne[0] == playerTwo[0])
                {
                    playerTwo.RemoveAt(0);
                    playerOne.RemoveAt(0);
                }
                if (playerOne.Count == 0 || playerTwo.Count == 0)
                {
                    break;
                }
            }
            if (playerOne.Count == 0)
            {
                Console.WriteLine($"Second player wins! Sum: {playerTwo.Sum()}");
            }

            else if (playerTwo.Count == 0)
            {
                Console.WriteLine($"First player wins! Sum: {playerOne.Sum()}");
            }
        }
    }
}
