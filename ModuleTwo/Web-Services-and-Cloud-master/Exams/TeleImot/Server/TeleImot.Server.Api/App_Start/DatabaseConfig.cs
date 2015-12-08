namespace TeleImot.Server.Api
{
    using System.Data.Entity;
    using TeleImot.Data;
    using TeleImot.Data.Migrations;

    public class DatabaseConfig
    {
        public static void Initialize()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<TeleImotDbContext, Configuration>());
        }
    }
}