namespace TeleImot.Services.Contracts
{
    using System.Linq;
    using Data.Models;
    using Common;

    public interface ICommentsServices
    {
        IQueryable<Comment> GetByRealEstateId(int id);

        IQueryable<Comment> GetByRealEstateId(int id, int page = 1, int pageSize = GlobalConstants.DefaultPageSize);

        IQueryable<Comment> CommentsByUser(string username);

        IQueryable<Comment> CommentsByUser(string username, int page = 1, int pageSize = GlobalConstants.DefaultPageSize);

        Comment Add(int id, string content);
    }
}
