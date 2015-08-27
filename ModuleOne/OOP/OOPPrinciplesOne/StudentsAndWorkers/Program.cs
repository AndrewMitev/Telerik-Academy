using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>() {
                    new Student("Ivan", "Peshev", 4.5f),
                    new Student("Kaloyan", "Dimitrov", 5.00f),
                    new Student("Vladimir", "Metrashev", 6.00f),
                    new Student("Dimitar", "Dimitrov", 2.00f),
                    new Student("Stoyan", "Vasilev", 2.50f),
                    new Student("Rally", "Bratanova", 5.75f),
                    new Student("Hristina", "Asenova", 6.00f),
                    new Student("Stoyan", "Bashev", 4.00f),
                    new Student("Emanoela", "Basheva", 6.00f),
                    new Student("Dimitar", "Bezergyanov", 3.50f),
                    new Student("Simeon", "Prisadov", 5.00f)
            };

            IEnumerable<Student> sortedStudents = SortStudents(students);

            Console.WriteLine("Sorted Students:\n");

            Print(sortedStudents);

            List<Worker> workers = new List<Worker>() { 
                new Worker("Pesho", "Obshtia", 100.20m, 8),
                new Worker("Kaloyan", "Dimitrov", 200m, 8),
                new Worker("Vladimir", "Metrashev", 160.25m, 8),
                new Worker("Dimitar", "Dimitrov", 122.22m, 8),
                new Worker("Stoyan", "Vasilev", 180.10m, 8),
                new Worker("Rally", "Bratanova", 300.90m, 8),
                new Worker("Hristina", "Asenova", 700m, 8),
                new Worker("Stoyan", "Bashev", 1000m, 8),
                new Worker("Emanoela", "Basheva", 100m, 4),
                new Worker("Dimitar", "Bezergyanov", 20000m, 4),
                new Worker("Simeon", "Prisadov", 210m, 8)
            };

            IEnumerable<Worker> sortedWorkers =
                from worker in workers
                orderby worker.MoneyPerHour() descending
                select worker;

            Console.WriteLine("\n\nWorkers sorted by money per hour:\n");

            Print(sortedWorkers);

            var list = students
                .Concat<Human>(workers)
                .OrderBy(x => x.Firstname)
                .ThenBy(x => x.Lastname);

            Console.WriteLine("\nMerged and sorted by Firstname and Lastname:\n");

            foreach (var item in list)
            {
                Console.WriteLine("{0} {1}", item.Firstname, item.Lastname);
            }

        }

        private static IEnumerable<Student> SortStudents(IEnumerable<Student> collection)
        {
            return from student in collection
              orderby student.Grade descending
              select student;
        }

        private static void Print<T>(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
