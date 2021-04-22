using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._List_Manipulation_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                string ending = Console.ReadLine();
                if (ending == "end")
                {
                    break;
                }
                string[] command = ending.Split();
                switch (command[0])
                {
                    case "Add":
                        numbers.Add(int.Parse(command[1]));
                        Console.WriteLine(string.Join(" ", numbers));
                        break;
                    case "Remove":
                        numbers.Remove(int.Parse(command[1]));
                        Console.WriteLine(string.Join(" ", numbers));
                        break;
                    case "RemoveAt":
                        numbers.RemoveAt(int.Parse(command[1]));
                        Console.WriteLine(string.Join(" ", numbers));
                        break;
                    case "Insert":
                        int numberToInsert = int.Parse(command[1]);
                        int indexToInsert = int.Parse(command[2]);
                        numbers.Insert(indexToInsert, numberToInsert);
                        Console.WriteLine(string.Join(" ", numbers));
                        break;
                    case "Contains":
                        int numberToChek = int.Parse(command[1]);
                        bool isContains = numbers.Contains(numberToChek);
                        if (isContains)
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;
                    case "PrintEven":
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            int curentNumber = numbers[i];
                            if (numbers[i] % 2 == 0)
                            {
                                Console.Write(curentNumber + " ");
                            }
                        }
                        Console.WriteLine();
                        break;

                    case "PrintOdd":
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            int curentNumber = numbers[i];
                            if (numbers[i] % 2 == 1)
                            {
                                Console.Write(curentNumber + " ");
                            }
                        }
                        Console.WriteLine();
                        break;

                    case "GetSum":
                        Console.WriteLine(numbers.Sum());
                        break;
                    case "Filter":
                        int index = int.Parse(command[2]);
                        if (command[1] == "<")
                        {
                            Console.WriteLine(string.Join(" ", numbers.FindAll(x => x < index)));
                        }
                        if (command[1] == ">")
                        {
                            Console.WriteLine(string.Join(" ", numbers.FindAll(x => x > index)));
                        }
                        if (command[1] == "<=")
                        {
                            Console.WriteLine(string.Join(" ", numbers.FindAll(x => x <= index)));
                        }
                        if (command[1] == ">=")
                        {
                            Console.WriteLine(string.Join(" ", numbers.FindAll(x => x >= index)));
                        }
                        break;
                }
            }
        }
    }
}
