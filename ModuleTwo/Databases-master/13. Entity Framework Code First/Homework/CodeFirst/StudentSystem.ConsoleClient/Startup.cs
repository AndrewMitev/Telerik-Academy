namespace StudentSystem.ConsoleClient
{
    using DataModels.Models;
    using Data;
    using System.Data.Entity;
    using System.Linq;
    using Data.Migrations;

    class Startup
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<StudentSystemDbContext, Configuration>());

            var db = new StudentSystemDbContext();
            var student = new Student
            {
                FirstName = "John",
                LastName = "3volta",
                FacultyNumber = "qwerty"
            };

            System.Console.WriteLine(db.Students.ToList().Count());
            db.Students.Add(student);
            db.SaveChanges();
        }
    }
}
