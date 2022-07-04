using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Student_Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfEntries = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> listOfStudents = new Dictionary<string, List<double>>();

            for (int i = 0; i < numberOfEntries; i++)
            {
                string studentName = Console.ReadLine();
                double studentGrade = double.Parse(Console.ReadLine());

                if (listOfStudents.ContainsKey(studentName))
                {
                    listOfStudents[studentName].Add(studentGrade);
                }
                else
                {
                    listOfStudents.Add(studentName, new List<double>() { studentGrade });
                }
            }

            foreach (var student in listOfStudents)
            {
                string name = student.Key;
                double avrGrade = student.Value.Average();
                if (avrGrade >= 4.50)
                {
                    Console.WriteLine($"{name} -> {avrGrade:f2}");
                }
            }
        }
    }
}
