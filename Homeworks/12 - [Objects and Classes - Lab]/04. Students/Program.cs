using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    class Program
    {
        private static IEnumerable<object> student;

        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<Student> list = new List<Student>();
            while (command != "end")
            {
                string[] info = command.Split().ToArray();

                string firstName = info[0];
                string lastName = info[1];
                int age = int.Parse(info[2]);
                string town = info[3];

                Student student = new Student();

                student.FirstName = firstName;
                student.LastName = lastName;
                student.Age = age;
                student.Town = town;

                list.Add(student);


                command = Console.ReadLine();
            }

            string filtredTown = Console.ReadLine();

            foreach (Student student in list)
            {
                if (student.Town == filtredTown)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }


        class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public string Town { get; set; }
        }
    }
}
