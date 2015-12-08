namespace TeleImot.Services.Contracts
{
    using System.Linq;
    using Data.Models;

    public interface IUserServices
    {
        IQueryable<User> Get(string username);

        void UpdateRate(int id, int rate);
    }
}
