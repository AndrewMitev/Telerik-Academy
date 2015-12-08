namespace TeleImot.Services
{
    using System.Linq;
    using TeleImot.Data.Models;
    using TeleImot.Data.Repositories;
    using Contracts;

    public class UserServices : IUserServices
    {
        private IRepository<User> users;

        public UserServices(IRepository<User> users)
        {
            this.users = users;
        }

        public IQueryable<User> Get(string username)
        {
            return this.users
                .All()
                .Where(u => u.UserName == username);
        }

        public void UpdateRate(int id, int rate)
        {
            var user = this.users.GetById(id);

            user.VotesSum += rate;
            user.VotesCount += 1;

            user.Rating = user.VotesSum / user.VotesCount;
            if (user.Rating < 1)
            {
                user.Rating = 1;
            }

            if (user.Rating > 5)
            {
                user.Rating = 5;
            }

            this.users.Update(user);
            this.users.SaveChanges();
        }
    }
}
