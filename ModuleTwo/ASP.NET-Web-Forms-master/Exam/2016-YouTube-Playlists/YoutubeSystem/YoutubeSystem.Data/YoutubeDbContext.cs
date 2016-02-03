namespace YoutubeSystem.Data
{
    using System;
    using System.Data.Entity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using YoutubeSystem.Models;
    using System.Data.Entity.ModelConfiguration.Conventions;

    public class YoutubeDbContext : IdentityDbContext<User>, IYoutubeDbContext
    {
        public YoutubeDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public IDbSet<Playlist> Playlists { get; set; }

        public IDbSet<Category> Categories { get; set; }

        public IDbSet<Video> Videos { get; set; }

        public IDbSet<Rating> Ratings { get; set; }

        public static YoutubeDbContext Create()
        {
            return new YoutubeDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder
            //    .Entity<User>()
            //    .HasOptional(u => u.GivenRatings)
            //    .WithRequired()
            //    .WillCascadeOnDelete(true);

            //modelBuilder
            //    .Entity<Playlist>()
            //    .HasOptional(p => p.Ratings)
            //    .WithOptionalDependent()
            //    .WillCascadeOnDelete(true);

            //modelBuilder
            //    .Entity<Rating>()
            //    .HasRequired(r => r.FromUser)
            //    .WithOptional()
            //    .WillCascadeOnDelete(false);

            //modelBuilder
            //    .Entity<Rating>()
            //    .HasRequired(r => r.ToPlaylist)
            //    .WithOptional()
            //    .WillCascadeOnDelete(false);

            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            base.OnModelCreating(modelBuilder);
        }
    }
}
