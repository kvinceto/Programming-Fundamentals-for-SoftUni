using System;
using System.Collections.Generic;

namespace _05._Students_2._0
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
                bool isInTheList = StudentIsInTheList(students, studentInformation);
                if (isInTheList)
                {
                    string firstName = studentInformation[0];
                    string lastName = studentInformation[1];
                    Student student = GetStudent(students, firstName, lastName);
                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.Age = int.Parse(studentInformation[2]);
                    student.HomeTown = studentInformation[3];
                }
                else
                {
                    Student student = new Student()
                    {
                        FirstName = studentInformation[0],
                        LastName = studentInformation[1],
                        Age = int.Parse(studentInformation[2]),
                        HomeTown = studentInformation[3]
                    };
                    students.Add(student);
                }
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

        private static Student GetStudent(List<Student> students, string firstName, string lastName)
        {
            Student existingStudent = null;
            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    existingStudent = student;
                }
            }

            return existingStudent;
        }

        private static bool StudentIsInTheList(List<Student> students, string[] studentInformation)
        {
            foreach (Student student in students)
            {
                if (student.FirstName == studentInformation[0] &&
                    student.LastName == studentInformation[1])
                {
                    return true;
                }
            }

            return false;
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
