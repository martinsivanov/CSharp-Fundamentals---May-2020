using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Order_by_Age
{
    class Program
    {
        public static void Main(string[] args)
        {
            string command = String.Empty;
            List<Person> list = new List<Person>();
            while ((command = Console.ReadLine()) != "End")
            {
                var commandElements = command.Split().ToArray();

                Person person = new Person(commandElements[0], commandElements[1], int.Parse(commandElements[2]));

                list.Add(person);

            }

            Console.WriteLine(String.Join(Environment.NewLine, list.OrderBy(x => x.Age)));
        }

        public class Person
        {
            public string Name { get; set; }
            public string Id { get; set; }
            public int Age { get; set; }
            public Person(string name, string id, int age)
            {
                this.Name = name;
                this.Id = id;
                this.Age = age;
            }


            public override string ToString()
            {
                return $"{this.Name} with ID: {this.Id} is {this.Age} years old.";
            }

        }

    }
}
