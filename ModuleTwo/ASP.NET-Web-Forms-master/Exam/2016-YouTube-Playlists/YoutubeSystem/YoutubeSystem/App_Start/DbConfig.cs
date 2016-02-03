namespace YoutubeSystem.App_Start
{
    using YoutubeSystem.Data;
    using System.Data.Entity;
    using Data.Migrations;

    public class DbConfig
    {
        public static void Initialize()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<YoutubeDbContext, Configuration>());

            YoutubeDbContext.Create().Database.Initialize(true);
        }
    }
}