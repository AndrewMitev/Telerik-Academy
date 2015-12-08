namespace SocialNetwork.ConsoleClient
{
    using Data;
    using Models.Entities;

    public class Startup
    {
        public static void Main()
        {
            SocialNetworkDbContext dbSocial = new SocialNetworkDbContext();

            using (dbSocial)
            {
                User newUser = new User();
                newUser.Username = "I know nothing man.";
                newUser.FirtsName = "John";
                newUser.LastName = "Snow";
                newUser.RegistrationDate = new System.DateTime(1002, 02, 03);

                dbSocial.Users.Add(newUser);
                dbSocial.SaveChanges();
                System.Console.WriteLine("Database created and user added.");
            }
        }
    }
}
