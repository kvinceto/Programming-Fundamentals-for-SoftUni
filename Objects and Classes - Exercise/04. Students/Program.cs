using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfStudents = int.Parse(Console.ReadLine());
            List<Student> listOfStudents = new List<Student>();

            for (int i = 0; i < countOfStudents; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                Student student = new Student(input[0], input[1], double.Parse(input[2]));
                listOfStudents.Add(student);
            }

            listOfStudents = listOfStudents.OrderByDescending(student => student.Grade).ToList();
            listOfStudents.ForEach(Console.WriteLine);
        }
    }

    class Student
    {
        public Student(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }
        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName}: {this.Grade:f2}".ToString();
        }
    }
}
