using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Tasks from 3 to 5 are here
 */
namespace FirstBeforeLast
{
    class Program
    {
        static void Main(string[] args)
        {
            // Problem 3: Write a method that from a given array of 
            //students finds all students whose first name is before its last name alphabetically.

            Console.WriteLine("Students whose first name is before their last alphabetically:\n");
            Student[] students = new Student[] { new Student("Andrey", "Mitev"), new Student("Mile", "Andreev") };
            Student[] filtered = FilterStudentsByName(students);
            PrintStudents(filtered);

            // Problem 4: Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.
            students = new Student[] { 
                new Student("Ivan", "Peshev", 22), 
                new Student("Dimitar", "Dimitrov", 65),
                new Student("Ivan", "Toshev", 13),
                new Student("Atanas", "Mladenov", 18),
                new Student("Kaloyan", "Mladenov", 28)
            };

            filtered = FilterByAge(students);

            Console.WriteLine("\nFiltered by age:");
            PrintStudents(filtered);

            // Problem 5: Using the extension methods OrderBy() and ThenBy() with 
            // lambda expressions sort the students by first name and last name in descending order.

            Console.WriteLine("\nSorted students:");
            students = students.OrderByDescending(x => x.FirstName).ThenByDescending(x => x.LastName).ToArray();
            PrintStudents(students);

            // Same thing done with LINQ

            var sorted =
                from student in students
                orderby student.FirstName descending, student.LastName descending
                select student;
            Console.WriteLine("\nSorted with LINQ:");
            PrintStudents(sorted.ToArray());

        }
        // Task 3 "First before last"
        public static Student[] FilterStudentsByName(Student[] students)
        {
            var items =
            from st in students
            where st.FirstName.CompareTo(st.LastName) < 0
            select st;

            return items.ToArray();
        }
        // Task 4 "Age range"
        public static Student[] FilterByAge(Student[] students)
        {
            var filters =
                from st in students
                where st.Age > 17 && st.Age < 25
                select st;

            return filters.ToArray();
        }

        private static void PrintStudents(Student[] students)
        {
            foreach (var item in students)
            {
                Console.WriteLine(item);
            }
        }
    }
}
