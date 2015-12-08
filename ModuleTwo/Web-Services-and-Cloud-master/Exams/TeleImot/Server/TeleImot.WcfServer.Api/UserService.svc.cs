namespace TeleImot.WcfServer.Api
{
    using ServiceContracts;
    using Data;
    using Data.Repositories;
    using Data.Models;
    using System.Linq;

    public class UserService : IUserService
    {
        public IQueryable<UserResponseModel> GetTopUsers()
        {
            GenericRepository<User> users = new GenericRepository<User>(new TeleImotDbContext());

            return users
                .All()
                .OrderBy(u => u.Rating)
                .Take(10)
                .Select(UserResponseModel.FromUser)
                .AsQueryable();
        }
    }
}
