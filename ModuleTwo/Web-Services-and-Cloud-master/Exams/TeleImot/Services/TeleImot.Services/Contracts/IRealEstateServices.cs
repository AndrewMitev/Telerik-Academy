namespace TeleImot.Services.Contracts
{
    using System.Linq;
    using Common;
    using Data.Models;

    public interface IRealEstateServices
    {
        int Add(string title, string description, string address, string contact, int construct, int type);

        IQueryable<RealEstate> All(int page = 1, int pageSize = GlobalConstants.DefaultPageSize);

        IQueryable<RealEstate> All();

        IQueryable GetSpecific(int id);


    }
}
