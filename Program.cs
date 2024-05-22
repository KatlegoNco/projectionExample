using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentApp
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of Student objects
            List<Student> students = new List<Student>
            {
                new Student { FirstName = "Kattttttttt", LastName = "Madueke", Age = 21},
                new Student { FirstName = "Kaylieyyyyy", LastName = "James", Age = 20},
                new Student { FirstName = "Zeeeeeeeeey", LastName = "Badiashile", Age = 20}
            };

            // Use LINQ to project a new anonymous type
            var projected = students.Select(s => new
            {
                FullName = $"{s.FirstName} {s.LastName}",
                AgeInMonths = s.Age * 12,
            }
            );

            // Display the results
            foreach (var item in projected)
            {
                Console.WriteLine($"Name: {item.FullName}, Age in Months: {item.AgeInMonths}");
            }

            // Wait for user input to exit
            Console.ReadLine();
        }
    }
}
