using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;
            List<Vehicle> list = new List<Vehicle>();




            while ((command = Console.ReadLine()) != "End")
            {
                string[] commands = command.Split().ToArray();

                string type = commands[0];
                string model = commands[1];
                string color = commands[2];
                string power = commands[3];

                Vehicle vehicle = new Vehicle(type, model, color, double.Parse(power));
                list.Add(vehicle);

            }

            string modelToPrint = Console.ReadLine();

            while (modelToPrint != "Close the Catalogue")
            {

                Console.WriteLine(list.FirstOrDefault(x => x.Model == modelToPrint).ToString());
                modelToPrint = Console.ReadLine();
            }

            var cars = list.FindAll(x => x.Type == "car");
            var trucks = list.FindAll(x => x.Type == "truck");
            var carSum = cars.Sum(x => x.HoursePower);
            var truckSum = trucks.Sum(x => x.HoursePower);

            var AvarageCars = carSum / cars.Count;
            var AvarageTrucks = truckSum / trucks.Count;
            if (cars.Count == 0)
            {
                AvarageCars = 0;
            }
            if (trucks.Count == 0)
            {
                AvarageTrucks = 0;
            }



            Console.WriteLine($"Cars have average horsepower of: {AvarageCars:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {AvarageTrucks:f2}.");

        }



    }

    public class Vehicle
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double HoursePower { get; set; }

        public Vehicle(string type, string model, string color, double power)
        {
            this.Type = type;
            this.Model = model;
            this.Color = color;
            this.HoursePower = power;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (this.Type == "car")
            {
                sb.AppendLine($"Type: Car");
            }
            if (this.Type == "truck")
            {
                sb.AppendLine($"Type: Truck");
            }


            sb.AppendLine($"Model: {this.Model}");
            sb.AppendLine($"Color: {this.Color}");
            sb.AppendLine($"Horsepower: {this.HoursePower}");

            return sb.ToString().Trim();
        }
    }

}
