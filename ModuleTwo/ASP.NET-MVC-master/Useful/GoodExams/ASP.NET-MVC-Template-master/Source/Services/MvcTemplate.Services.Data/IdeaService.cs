namespace MvcTemplate.Services.Data
{
    using System;
    using System.Linq;
    using MvcTemplate.Data.Common;
    using MvcTemplate.Data.Models;

    public class IdeaService : IIdeaService
    {
        private const int DefaultPage = 3;
        private IDbRepository<Idea> ideas;

        public IdeaService(IDbRepository<Idea> ideas)
        {
            this.ideas = ideas;
        }

        public void Add(string title, string description, string ip, string userId)
        {
            Idea idea = new Idea();
            if (userId != null)
            {
                idea.AuthorId = userId;
            }

            idea.Title = title;
            idea.Description = description;
            idea.AuthorIP = ip;

            this.ideas.Add(idea);
            this.ideas.Save();
        }

        public void Delete(int id)
        {
            var idea = this.ideas.GetById(id);
            this.ideas.Delete(idea);
            this.ideas.Save();
        }

        public IQueryable<Idea> GetAll()
        {
            return this.ideas.All();
        }

        public IQueryable<Idea> GetAll(int page)
        {
            return this.ideas
                .All()
                .OrderBy(i => i.CreatedOn)
                .ThenBy(i => i.Votes.Count)
                .Skip((page - 1) * DefaultPage)
                .Take(DefaultPage);
        }

        public Idea GetById(int id)
        {
            var idea = this.ideas.GetById(id);
            return idea;
        }

        public void Update(int id, string title, string description)
        {
            var databaseIdea = this.GetById(id);
            databaseIdea.Title = title;
            databaseIdea.Description = description;
            this.ideas.Save();
        }
    }
}
