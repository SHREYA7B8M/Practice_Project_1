using Student_Data_Practice_Project;
using System;
using System.Collections.Generic;
using System.IO;

namespace StudentDataDisplay
{
    class Program
    {
        static void Main(string[] args)
        {
            List<StudentData> students = new List<StudentData>();

            string filePath = @"C:\Users\KIIT\Desktop\Git Exercise\Practice_Projects\Student_Data.txt.txt";
            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                string[] data = line.Split(',');
                if (data.Length == 3)
                {
                    StudentData student = new StudentData
                    {
                        Name = data[0],
                        Age = int.Parse(data[1]),
                        Major = data[2]
                    };
                    students.Add(student);
                }
            }

            foreach (var student in students)
            {
                Console.WriteLine($"Name: {student.Name}, \tAge: {student.Age}, \tMajor: {student.Major}\n");
            }

            Console.ReadKey();
        }
    }
}
