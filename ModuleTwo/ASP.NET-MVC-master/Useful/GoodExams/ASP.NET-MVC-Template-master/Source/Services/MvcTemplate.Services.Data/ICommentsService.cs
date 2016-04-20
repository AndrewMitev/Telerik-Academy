namespace MvcTemplate.Services.Data
{
    using System.Linq;
    using MvcTemplate.Data.Models;

    public interface ICommentsService
    {
        IQueryable<Comment> GetAll();

        IQueryable<Comment> GetAll(int page);

        Comment GetById(int id);

        void Delete(int id);

        void Update(int id, string content, string authorEmail);
    }
}
