namespace TeleImot.Services
{
    using System.Linq;
    using Common;
    using Data.Models;
    using Data.Repositories;
    using Contracts;

    public class CommentsServices : ICommentsServices
    {
        private IRepository<Comment> comments;
        private IRepository<User> users;

        public CommentsServices(IRepository<Comment> comments, IRepository<User> users)
        {
            this.comments = comments;
            this.users = users;
        }

        public IQueryable<Comment> GetByRealEstateId(int id)
        {
            return this.comments
                .All()
                .Where(c => c.RealEstateId == id)
                .OrderBy(c => c.CommentedOn)
                .Take(GlobalConstants.TakeDefault);
        }

        public IQueryable<Comment> GetByRealEstateId(int id, int page = 1, int pageSize = GlobalConstants.DefaultPageSize)
        {
            return this.comments
                .All()
                .Where(c => c.RealEstateId == id)
                .OrderBy(c => c.CommentedOn)
                .Skip((page - 1) * pageSize)
                .Take(pageSize);
        }

        public IQueryable<Comment> CommentsByUser(string username)
        {
            var user = this.users
                .All()
                .FirstOrDefault(u => u.UserName == username);

            return user.Comments
                .OrderBy(c => c.CommentedOn)
                .Take(GlobalConstants.TakeDefault)
                .AsQueryable();
        }

        public IQueryable<Comment> CommentsByUser(string username, int page = 1, int pageSize = GlobalConstants.DefaultPageSize)
        {
            var user = this.users
             .All()
             .FirstOrDefault(u => u.UserName == username);

            return user.Comments
                .OrderBy(c => c.CommentedOn)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .AsQueryable();
        }

        public Comment Add(int id, string content)
        {
            var newComment = new Comment()
            {
                RealEstateId = id,
                Content = content
            };

            this.comments.Add(newComment);

            this.comments.SaveChanges();

            return newComment;
        }
    }
}
