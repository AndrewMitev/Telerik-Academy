using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Countries.Models
{
    public static class SeedData
    {
        public static void Seed()
        {
            var context = new ApplicationDbContext();

            var asia = new Continent()
            {
                Name = "Asia"
            };

            var europe = new Continent()
            {
                Name = "Europe"
            };

            context.Continents.Add(asia);
            context.Continents.Add(europe);
            context.SaveChanges();

            var china = new Country()
            {
                Continent = asia,
                Language = "chinese",
                Name = "China",
                Population = 2123452123
            };

            var romania = new Country()
            {
                Continent = europe,
                Language = "romanian",
                Name = "Romania",
                Population = 1000000
            };

            context.Countries.Add(romania);
            context.Countries.Add(china);

            var buku = new Town()
            {
                Name = "Bukuresht",
                Country = romania
            };

            var pekin = new Town()
            {
                Name = "Pekin",
                Country = china
            };

            context.Towns.Add(buku);
            context.Towns.Add(pekin);
            context.SaveChanges();

        }
    }
}