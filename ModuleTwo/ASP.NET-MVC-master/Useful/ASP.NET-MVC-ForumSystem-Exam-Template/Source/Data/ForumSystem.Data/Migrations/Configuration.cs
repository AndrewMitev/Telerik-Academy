namespace ForumSystem.Data.Migrations
{
    using Models;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;

            // TODO: Remove in production
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(ApplicationDbContext context)
        {
            if (!context.Feedbacks.Any())
            {
                for (int i = 1; i <= 18; i++)
                {
                    var feedback = new Feedback()
                    {
                        Title = string.Format("Feedback {0}", i),
                        Content = string.Format("Feedback <b>content></b> {0}", i)
                    };

                    context.Feedbacks.Add(feedback);
                }

                context.SaveChanges();
            }

            if (!context.Tags.Any())
            {
                var tagList = new List<Tag>();
                for (int i = 1; i <= 20; i++)
                {
                    var tag = new Tag() { Name = string.Format("Tag {0}", i) };
                    context.Tags.Add(tag);
                    tagList.Add(tag);
                }

                var tagIndex = 0;
                for (int i = 1; i <= 20; i++)
                {
                    var post = new Post() { Content = string.Format("Post content {0}", i), Title = string.Format("Post Title {0}", i) };
                    for (int j = 0; j < 5; j++)
                    {
                        post.Tags.Add(tagList[tagIndex % tagList.Count]);
                        tagIndex++;
                    }

                    context.Posts.Add(post);
                }

                context.SaveChanges();
            }

            if (!context.Banners.Any())
            {
                for (int i = 1; i <= 10; i++)
                {
                    var banner = new Banner
                    {
                        ImageUrl = "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcQnByOfq0x1ah25X_7AA-Or7E2Pm7TiNtlJ9nEhn45BQdboHlII"
                    };

                    context.Banners.Add(banner);
                }

                context.SaveChanges();
            }

            if (!context.TextAds.Any())
            {
                for (int i = 1; i < 11; i++)
                {
                    var add = new TextAd
                    {
                        Text = $"text add number {i}"
                    };

                    context.TextAds.Add(add);
                }

                context.SaveChanges();
            }
        }
    }
}
