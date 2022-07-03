using System;
using System.Collections.Generic;

namespace _04._Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Student> students = new List<Student>();

            while (input != "end")
            {
                string[] studentInformation = input.Split(' ');
                Student student = new Student()
                {
                    FirstName = studentInformation[0],
                    LastName = studentInformation[1],
                    Age = int.Parse(studentInformation[2]),
                    HomeTown = studentInformation[3]
                };
                students.Add(student);
                input = Console.ReadLine();
            }

            string cityName = Console.ReadLine();
            foreach (Student student in students)
            {
                if (student.HomeTown == cityName)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }
    }

    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }
}
