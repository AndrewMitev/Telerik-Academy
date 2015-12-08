namespace TeleImot.Services
{
    using Data.Repositories;
    using Data.Models;
    using Contracts;
    using System.Linq;
    using Common;

    public class RealEstateServices : IRealEstateServices
    {
        private IRepository<RealEstate> realEstates;

        public RealEstateServices(IRepository<RealEstate> realEstatesDependency)
        {
            this.realEstates = realEstatesDependency;
        }

        public IQueryable<RealEstate> All()
        {
            return this.realEstates
                .All()
                .OrderByDescending(r => r.ConstructionYear)
                .Take(GlobalConstants.TakeDefault);
        }

        public IQueryable<RealEstate> All(int page = 1, int pageSize = GlobalConstants.DefaultPageSize)
        {
            return this.realEstates
                .All()
                .OrderByDescending(r => r.ConstructionYear)
                .Skip((page - 1) * pageSize)
                .Take(pageSize);
        }

        public IQueryable GetSpecific(int id)
        {
            return this.realEstates
                .All()
                .Select(r => r.Id == id)
                .AsQueryable();
        }

        public int Add(string title, string description, string address, string contact, int construcionYear, int type)
        {
            RealEstate newEstate = new RealEstate() {
                Title = title,
                Description = description,
                Type = (Type)type,
                SellOption = SellOption.ForRenting,
                Address = address,
                ConstructionYear = construcionYear,
                Contact = contact,
            };


            this.realEstates.Add(newEstate);

            this.realEstates.SaveChanges();

            return newEstate.Id;
        }
    }
}
