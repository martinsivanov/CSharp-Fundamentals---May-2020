using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> listCars = new List<Car>();
            List<Truck> listTruck = new List<Truck>();

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] commands = input.Split("/").ToArray();

                string type = commands[0];

                if (type == "Car")
                {
                    Car car = new Car(commands[1], commands[2], commands[3]);
                    listCars.Add(car);

                }
                else if (type == "Truck")
                {
                    Truck truck = new Truck(commands[1], commands[2], commands[3]);
                    listTruck.Add(truck);

                }

                Cataloge cataloge = new Cataloge(listCars, listTruck);

            }


            if (listCars.Count > 0)
            {
                Console.WriteLine("Cars:");
                Console.WriteLine(String.Join(Environment.NewLine, listCars.OrderBy(x => x.Brand)));
            }
            if (listTruck.Count > 0)
            {
                Console.WriteLine("Trucks:");
                Console.WriteLine(String.Join(Environment.NewLine, listTruck.OrderBy(x => x.Brand)));
            }

        }

        public class Car
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public string HorsePower { get; set; }


            public Car(string brand, string model, string hoursePower)
            {
                this.Brand = brand;
                this.Model = model;
                this.HorsePower = hoursePower;
            }

            public override string ToString()
            {
                StringBuilder stringBuilder = new StringBuilder();


                stringBuilder.AppendLine($"{this.Brand}: {this.Model} - {this.HorsePower}hp");

                return stringBuilder.ToString().Trim();
            }
        }

        public class Truck
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public string Weight { get; set; }


            public Truck(string brand, string model, string weight)
            {
                this.Brand = brand;
                this.Model = model;
                this.Weight = weight;
            }
            public override string ToString()
            {
                StringBuilder stringBuilder = new StringBuilder();


                stringBuilder.AppendLine($"{this.Brand}: {this.Model} - {this.Weight}kg");

                return stringBuilder.ToString().Trim();
            }
        }
        public class Cataloge
        {
            public List<Car> car { get; set; }
            public List<Truck> truck { get; set; }

            public Cataloge(List<Car> listCars, List<Truck> listTruck)
            {
                this.car = listCars;
                this.truck = listTruck;
            }


        }
    }
}
