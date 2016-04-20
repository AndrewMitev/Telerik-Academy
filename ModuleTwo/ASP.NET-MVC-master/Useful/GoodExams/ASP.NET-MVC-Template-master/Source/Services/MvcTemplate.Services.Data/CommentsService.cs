namespace MvcTemplate.Services.Data
{
    using System;
    using System.Linq;
    using MvcTemplate.Data.Common;
    using MvcTemplate.Data.Models;

    public class CommentsService : ICommentsService
    {
        private const int DefaultPage = 4;
        private IDbRepository<Comment> comments;

        public CommentsService(IDbRepository<Comment> comments)
        {
            this.comments = comments;
        }

        public void Delete(int id)
        {
            var comment = this.GetById(id);
            this.comments.Delete(comment);
            this.comments.Save();
        }

        public IQueryable<Comment> GetAll()
        {
            return this.comments.All();
        }

        public IQueryable<Comment> GetAll(int page)
        {
            return this.comments
               .All()
               .OrderBy(i => i.CreatedOn)
               .Skip((page - 1) * DefaultPage)
               .Take(DefaultPage);
        }

        public Comment GetById(int id)
        {
            var comment = this.comments.GetById(id);
            return comment;
        }

        public void Update(int id, string content, string authorEmail)
        {
            var databaseComment = this.GetById(id);
            databaseComment.Content = content;
            databaseComment.AuthorEmail = authorEmail;
            this.comments.Save();
        }
    }
}
