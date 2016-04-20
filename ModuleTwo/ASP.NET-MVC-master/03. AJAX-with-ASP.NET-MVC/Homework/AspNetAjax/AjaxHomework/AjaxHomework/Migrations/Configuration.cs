namespace AjaxHomework.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Validation;
    using System.Diagnostics;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<AjaxHomework.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(AjaxHomework.Models.ApplicationDbContext context)
        {
            if (context.Movies.Any())
            {
                return;
            }

            var leni = new Human() { Name = "Leonardo Di Caprio", Age = 45, isMale = true, Studio = "DaVinciStudio", StudioAddress = "Mahagon City, str.18 of OÇlaghanag." };
            var jesi = new Human() { Name = "Jesica Alba", Age = 26, isMale = false };
            
            context.Humans.AddOrUpdate(
                    leni,
                    jesi
                );

            context.Movies.AddOrUpdate(
                    new Movie() { Title="Sheep die alone!", Year=2017, Director="John Smih", LeadingMaleRole=leni, LeadingFemaleRole=jesi},
                    new Movie() { Title="Ain't gonna sleep", Year=1982, Director="Johny Be", LeadingMaleRole = leni, LeadingFemaleRole=jesi}
                );

            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}",
                                                validationError.PropertyName,
                                                validationError.ErrorMessage);
                    }
                }
            }
        }
    }
}
