namespace YoutubeSystem.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Validation;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;
    public sealed class Configuration : DbMigrationsConfiguration<YoutubeSystem.Data.YoutubeDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(YoutubeSystem.Data.YoutubeDbContext context)
        {
            if (context.Users.Any())
            {
                return;
            }

            var admin = new Models.User() {
                FirstName = "peshoq",
                LastName = "someoneov",
                UserName = "admin"
            };

            for (int i = 1; i <= 5; i++)
            {
                var user = new Models.User() {
                    FirstName=$"userFirstName{i}",
                    LastName=$"userLastName{i}",
                    UserName=$"user{i}"
                };

                context.Users.Add(admin);
            }

            for (int i = 1; i < 31; i++)
            {
                var cat = new Models.Category()
                {
                    Name = $"category{i}"
                };

                context.Categories.Add(cat);
                context.SaveChanges();
            }

            //var vid = new Models.Video()
            //{
            //    Url = "https://www.youtube.com/watch?v=M46Shg-Wves"
            //};

            //context.Videos.Add(vid);

            //var rate = new Models.Rating()
            //{
            //    Value = 1
            //};

            //context.Ratings.Add(rate);

            for (int i = 1; i < 11; i++)
            {
                var playlist = new Models.Playlist()
                {
                    Title = $"title{i}",
                    Description = $"desc{i}",
                    Author = admin,
                    Category = context.Categories.FirstOrDefault(),
                    DateCreated = DateTime.Now
                };

                //playlist.Videos.Add(vid);
                //playlist.Ratings.Add(rate);

                context.Playlists.Add(playlist);
            }

            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                StringBuilder sb = new StringBuilder();

                foreach (var failure in ex.EntityValidationErrors)
                {
                    sb.AppendFormat("{0} failed validation\n", failure.Entry.Entity.GetType());
                    foreach (var error in failure.ValidationErrors)
                    {
                        sb.AppendFormat("- {0} : {1}", error.PropertyName, error.ErrorMessage);
                        sb.AppendLine();
                    }
                }

                throw new DbEntityValidationException(
                    "Entity Validation Failed - errors follow:\n" +
                    sb.ToString(), ex
                ); // Add the original exception as the innerException
            }
        }
    }
}
