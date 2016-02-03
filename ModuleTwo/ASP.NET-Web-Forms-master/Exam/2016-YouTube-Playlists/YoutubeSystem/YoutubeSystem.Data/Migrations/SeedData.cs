namespace YoutubeSystem.Data.Migrations
{
    using YoutubeSystem.Models;
    using System;
    using System.Collections.Generic;

    public class SeedData
    {
        public static Random Rand = new Random();

        public User Author { get; set; }

        public SeedData(User author)
        {
            
        }
    }
}