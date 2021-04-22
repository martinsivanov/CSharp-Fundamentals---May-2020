using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Need_for_Speed_III
{

    class Cars
    {
        public int Mileage { get; set; }
        public int Fuel { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Cars> AllCars = new Dictionary<string, Cars>();


            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("|").ToArray();

                string name = input[0];
                int mileage = int.Parse(input[1]);
                int fuel = int.Parse(input[2]);

                Cars cars = new Cars() { Mileage = mileage, Fuel = fuel };

                AllCars.Add(name, cars);
                
            }

            string command = Console.ReadLine();

            while (command != "Stop")
            {
                string[] commandArgs = command.Split(" : ").ToArray();

                if (commandArgs.Contains("Drive"))
                {
                    string name = commandArgs[1];
                    int distance = int.Parse(commandArgs[2]);
                    int fuel = int.Parse(commandArgs[3]);

                    if (AllCars.ContainsKey(name))
                    {
                        if (AllCars[name].Fuel < fuel)
                        {
                            Console.WriteLine("Not enough fuel to make that ride");
                        }
                        else
                        {
                            AllCars[name].Mileage += distance;
                            AllCars[name].Fuel -= fuel;

                            Console.WriteLine($"{name} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                        }
                        if (AllCars[name].Mileage >= 100000)
                        {
                            AllCars.Remove(name);
                            Console.WriteLine($"Time to sell the {name}!");
                        }
                    }
                   

                }
                if (commandArgs.Contains("Refuel"))
                {
                    string name = commandArgs[1];
                    int fuel = int.Parse(commandArgs[2]);
                    
                    if (AllCars[name].Fuel + fuel > 75)
                    {
                        fuel = 75 - AllCars[name].Fuel;
                        AllCars[name].Fuel = 75;
                    }
                    else
                    {
                        AllCars[name].Fuel += fuel;
                    }
                    Console.WriteLine($"{name} refueled with {fuel} liters");
                }

                if (commandArgs.Contains("Revert"))
                {
                    string name = commandArgs[1];
                    int kilomitres = int.Parse(commandArgs[2]);

                    if (AllCars[name].Mileage - kilomitres < 10000)
                    {
                        AllCars[name].Mileage = 10000;
                    }
                    else
                    {
                        AllCars[name].Mileage -= kilomitres;
                        Console.WriteLine($"{name} mileage decreased by {kilomitres} kilometers");
                    }
                }



                command = Console.ReadLine();
            }

            AllCars = AllCars.OrderByDescending(m => m.Value.Mileage).ThenBy(n => n.Key).ToDictionary(a => a.Key, b => b.Value);

            foreach (var car in AllCars)
            {
                Console.WriteLine($"{car.Key} -> Mileage: {car.Value.Mileage} kms, Fuel in the tank: {car.Value.Fuel} lt.");
            }
        }
    }
}
