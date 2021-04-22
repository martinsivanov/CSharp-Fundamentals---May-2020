using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ShootForTheWin
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();
            int countTargets = 0;

            while (command != "End")
            {
                // 24 50 36 70
                int index = int.Parse(command);
                if (index >= 0 && index < list.Count)
                {
                    int temp = list[index];
                    list.RemoveAt(index);
                    list.Insert(index, -1);

                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] > temp && i != index && list[i] != -1)
                        {
                            list[i] -= temp;
                        }
                        else if (list[i] <= temp && i != index && list[i] != -1)
                        {
                            list[i] += temp;
                        }
                    }
                }
                
                command = Console.ReadLine();
            }
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == -1)
                {
                    countTargets++;
                }
            }

            Console.WriteLine($"Shot targets: {countTargets} -> " + String.Join(" ",list));
        }
    }
}
