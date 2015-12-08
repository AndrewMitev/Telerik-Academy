namespace PetStore.ConsoleClient
{
    using System;
    using System.Collections.Generic;
    using Utils;

    public class Startup
    {
        private static List<Species> cachedSpecies;

        public static void Main()
        {
            cachedSpecies = new List<Species>();
            PetStoreEntities dbPets = new PetStoreEntities();
            using (dbPets)
            {
                //AddRandomCountries(dbPets);
                AddRandomSpecies(dbPets);
                //AddRandomPets(dbPets);
                //AddRandomCategories(dbPets);
                AddRandomProducts(dbPets);
            }
        }

        private static void AddRandomCountries(PetStoreEntities dbPets)
        {
                for (int counter = 0; counter < 20; counter++)
                {
                    Country randomCountry = new Country();
                    randomCountry.Name = CustomRandomGenerator.GetRandomString(0, 49);

                    dbPets.Countries.Add(randomCountry);
                }

                dbPets.SaveChanges();
                Console.WriteLine("Random countries successfully added!");
        }

        private static void AddRandomSpecies(PetStoreEntities dbPets)
        {
                int randomCountryId = CustomRandomGenerator.GetRandomNumber(1, 20);

                for (int counter = 0; counter < 100; counter++)
                {
                    Species randomSpecies = new Species();
                    randomSpecies.Name = CustomRandomGenerator.GetRandomString(5, 49);

                    if (counter % 5 == 0)
                    {
                        randomCountryId = CustomRandomGenerator.GetRandomNumber(1, 20);
                    }

                    randomSpecies.OriginCountryId = randomCountryId;

                    cachedSpecies.Add(randomSpecies);
                    dbPets.Species.Add(randomSpecies);
                }

                dbPets.SaveChanges();
                Console.WriteLine("Random species successfully added!");
        }

        private static void AddRandomPets(PetStoreEntities dbPets)
        {
            int randomSpeciesId = CustomRandomGenerator.GetRandomNumber(13, 112);

            for (int counter = 0; counter < 5000; counter++)
            {
                Pet randomPet = new Pet();

                if (counter % 50 == 0)
                {
                    randomSpeciesId = CustomRandomGenerator.GetRandomNumber(13, 112);
                }

                randomPet.SpeciesId = randomSpeciesId;

                randomPet.BirthDate = CustomRandomGenerator.GetRandomDate();

                randomPet.Price = (decimal)CustomRandomGenerator.GetRandomDouble();

                randomPet.ColorId = CustomRandomGenerator.GetRandomNumber(1, 4);

                dbPets.Pets.Add(randomPet);

                if (counter % 500 == 0)
                {
                    dbPets.SaveChanges();
                }
            }

            dbPets.SaveChanges();
            Console.WriteLine("Random pets successfully added!");
        }

        private static void AddRandomCategories(PetStoreEntities dbPets)
        {
            for (int counter = 0; counter < 50; counter++)
            {
                Category randomCategory = new Category();
                randomCategory.Name = CustomRandomGenerator.GetRandomString(5, 19);

                dbPets.Categories.Add(randomCategory);
            }

            dbPets.SaveChanges();

            Console.WriteLine("Random categories successfully added!");
        }

        private static void AddRandomProducts(PetStoreEntities dbPets)
        {
            int randomCategoryId = CustomRandomGenerator.GetRandomNumber(1, 50);

            for (int counter = 0; counter < 20000; counter++)
            {
                Product randomProduct = new Product();

                randomProduct.Name = CustomRandomGenerator.GetRandomString(5, 25);
                randomProduct.Price = (decimal)CustomRandomGenerator.GetRandomDouble(10.0d, 10000.0d);

                if (counter % 400 == 0)
                {
                    randomCategoryId = CustomRandomGenerator.GetRandomNumber(1, 50);
                }

                randomProduct.CategoryId = randomCategoryId;

                for (int i = 0; i < 2; i++)
                {
                    int randomSpeciesPositionFromCache = CustomRandomGenerator.GetRandomNumber(0, 99);
                    randomProduct.Species.Add(cachedSpecies[randomSpeciesPositionFromCache]);
                }

                dbPets.Products.Add(randomProduct);

                if (counter % 500 == 0)
                {
                    dbPets.SaveChanges();
                }
            }

            dbPets.SaveChanges();
            Console.WriteLine("Random products successfully added.");
        }
    }
}