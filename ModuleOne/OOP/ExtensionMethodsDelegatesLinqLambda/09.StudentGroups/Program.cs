using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Tasks 9, 10, 11, 12, 13, 14, 15, 18, 19 are implemented here!!!
namespace _09.StudentGroups
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student> { 
                new Student("Gosho", "Ivanov", "123406", "+034424", "toshe@гмаил.цом", new List<int>{2, 3, 4}, 2),
                new Student("Dimitur", "Dimitrov", "42423", "+08893723", "nastyPiche@abv.bg", new List<int>{4, 5, 6}, 3),
                new Student("Ivanka", "Pencheva", "233423511", "+0287364", "megaCreep@abv.bg", new List<int>{6,6,6}, 1),
                new Student("Anastaska", "Damianova", "1232231212", "+0092932323", "MegaDance@abv.bg", new List<int>{2, 2}, 2)
            };

            var sorted =
                from student in students
                where student.GroupNumber == 2
                orderby student.FirstName
                select student;

            Console.WriteLine("Students From Group 2 selected with Linq:\n");
            PrintStudents(sorted);

            //using extension methods
            Console.WriteLine("Sorted with extension methods:\n");
            sorted = students.FindAll(x => x.GroupNumber == 2).OrderBy(x => x.FirstName);

            PrintStudents(sorted);

            //task 11
            var s =
                from student in students
                where student.Email.Substring(student.Email.IndexOf('@'), student.Email.Length - student.Email.IndexOf('@')).Equals("@abv.bg")
                select student;

            Console.WriteLine("Students with emails in ABV:\n");
            PrintStudents(s);


            //task 12

            var shopi =
                from student in students
                where student.Tel.Substring(0, 3).Equals("+02")
                select student;

            Console.WriteLine("Students in Sofia:\n");
            PrintStudents(shopi);

            //task 13
            var excellent =
                from student in students
                where student.Marks.Contains(6)
                select new
                {
                    FullName = student.FirstName + " " + student.LastName,
                    MarksList = student.Marks
                };

            Console.WriteLine("Excellent Students:\n");
            foreach (var student in excellent)
            {
                Console.WriteLine("Student: " + student.FullName);
                Console.WriteLine("Grades: " + String.Join(", ", student.MarksList));
            }

            // Task 14
            var poor = students.FindAll(x => x.Marks.FindAll(y => y == 2).Count == 2).Select(x => new {
                FullName = x.FirstName + " " + x.LastName,
                Marks = x.Marks
            });

            Console.WriteLine("\nPoor students:\n");
            foreach (var student in poor)
            {
                Console.WriteLine("Student: " + student.FullName);
                Console.WriteLine("Grades: " + String.Join(", ", student.Marks));
            }

            //Task 15
            var specific =
                from student in students
                where student.FN[4] == '0' && student.FN[5] == '6'
                select student;

            Console.WriteLine("\nGrades of students that enrolled in 2006:");
            foreach (var item in specific)
            {
                Console.WriteLine(String.Join(", ", item.Marks));
            }

            //task 18
            var sortedByGroup =
                from student in students
                orderby student.GroupNumber
                select student;

            Console.WriteLine("\nStudent grouped by group number:\n");
            PrintStudents(sortedByGroup);

            //task 19
            var newlySortedByGroup = students.OrderBy(x => x.GroupNumber);

        }

        private static void PrintStudents(IEnumerable<Student> students)
        {
            foreach (var item in students)
            {
                Console.WriteLine(item);
            }
        }
    }
}
