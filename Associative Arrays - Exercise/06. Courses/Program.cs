using System;
using System.Collections.Generic;

namespace _06._Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> listOfCourses = new Dictionary<string, List<string>>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(" : ");
                if (input[0] == "end")
                {
                    break;
                }

                string courseName = input[0];
                string studentName = input[1];

                if (listOfCourses.ContainsKey(courseName))
                {
                    listOfCourses[courseName].Add(studentName);
                }
                else
                {
                    listOfCourses.Add(courseName, new List<string>(){studentName});
                }
            }

            foreach (var course in listOfCourses)
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");
                foreach (var student in course.Value)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
