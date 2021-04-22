using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> list = new List<Student>();
            for (int i = 0; i < n; i++)
            {
                string[] commands = Console.ReadLine().Split().ToArray();

                Student student = new Student(commands[0], commands[1], double.Parse(commands[2]));

                list.Add(student);
            }

            Console.WriteLine(String.Join(Environment.NewLine, list.OrderByDescending(x => x.Grade)));
        }

        public class Student
        {
            public string FirstName { get; set; }
            public string SecondName { get; set; }
            public double Grade { get; set; }

            public Student(string firstName, string secondName, double grade)
            {
                this.FirstName = firstName;
                this.SecondName = secondName;
                this.Grade = grade;
            }

            public override string ToString()
            {

                return $"{this.FirstName} {this.SecondName}: {this.Grade:f2}";
            }
        }
    }
}

