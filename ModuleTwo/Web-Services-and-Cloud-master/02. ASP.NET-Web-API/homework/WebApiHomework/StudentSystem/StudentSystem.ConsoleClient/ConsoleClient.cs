namespace StudentSystem.ConsoleClient
{
    using System;
    using System.Linq;
    using Data;
    using Models;
    using System.Collections.Generic;

    public class ConsoleClient
    {
        public static void PrintStudents(IEnumerable<Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine(student.FirstName);
            }
        }

        public static void Main()
        {
            var data = new StudentsSystemData();

            var students = data.Students.All().ToList();

            foreach (var student in students)
            {
                Console.WriteLine(student.FirstName);
            }
        }
    }
}
