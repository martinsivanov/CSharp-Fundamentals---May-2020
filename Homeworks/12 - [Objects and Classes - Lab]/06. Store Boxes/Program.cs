using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06._Store_Boxes
{
    class Program
    {
        public static void Main(string[] args)
        {

            List<Box> boxes = new List<Box>();
            string command = string.Empty;
            double priceForBox = 0;
            while ((command = Console.ReadLine()) != "end")
            {
                var data = command.Split().ToArray();

                string serialNum = data[0];
                string itemName = data[1];
                int itemQuantity = int.Parse(data[2]);
                double itemPrice = double.Parse(data[3]);
                priceForBox = itemQuantity * itemPrice;

                Item item = new Item(itemName, itemPrice);
                Box box = new Box(item, serialNum, itemQuantity, priceForBox);


                boxes.Add(box);

            }

            Console.WriteLine(String.Join(Environment.NewLine, boxes.OrderByDescending(x => x.PriceForABox)));
        }

        public class Item
        {
            public string Name { get; set; }
            public double Price { get; set; }

            public Item(string itemName, double itemPrice)
            {
                this.Name = itemName;
                this.Price = itemPrice;
            }
        }
        public class Box
        {
            public Box(Item item, string Serialnum, int ItemQuantity, double priceForAbox)
            {
                this.SerialNum = Serialnum;
                this.ItemQuantity = ItemQuantity;
                this.Item = item;
                this.PriceForABox = priceForAbox;
            }

            public string SerialNum { get; set; }
            public Item Item { get; set; }
            public int ItemQuantity { get; set; }
            public double PriceForABox { get; set; }


            public override string ToString()
            {
                StringBuilder stringBuilder = new StringBuilder();

                stringBuilder.AppendLine($"{this.SerialNum}");
                stringBuilder.AppendLine($"-- {this.Item.Name} - ${this.Item.Price:f2}: {this.ItemQuantity}");
                stringBuilder.AppendLine($"-- ${this.PriceForABox:f2}");
                return stringBuilder.ToString().Trim();
            }
        }
    }
}
