namespace StudentSystem.Data.Migrations
{
    using DataModels.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<StudentSystem.Data.StudentSystemDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(StudentSystem.Data.StudentSystemDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Students.AddOrUpdate(
              new Student { FirstName = "Andrew Peters", LastName = "something" },
              new Student { FirstName = "Andrew Peters 2", LastName = "something" },
              new Student { FirstName = "Andrew Peters 3", LastName = "something" },
              new Student { FirstName = "Andrew Peters 4", LastName = "something" },
              new Student { FirstName = "Andrew Peters 5", LastName = "something" },
              new Student { FirstName = "Andrew Peters 6", LastName = "something" },
              new Student { FirstName = "Andrew Peters 7", LastName = "something" }
            );
            //
        }
    }
}
