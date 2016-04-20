namespace MvcTemplate.Services.Data
{
    using System.Linq;
    using MvcTemplate.Data.Models;

    public interface IIdeaService : IService
    {
        IQueryable<Idea> GetAll();

        IQueryable<Idea> GetAll(int page);

        Idea GetById(int id);

        void Update(int id, string title, string description);

        void Delete(int id);

        void Add(string title, string description, string ip, string userId);
    }
}
