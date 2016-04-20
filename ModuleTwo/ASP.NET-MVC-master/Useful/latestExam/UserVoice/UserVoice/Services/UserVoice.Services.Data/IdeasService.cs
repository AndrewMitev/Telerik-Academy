using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserVoice.Data.Common;
using UserVoice.Data.Models;
using UserVoice.Services.Data.Interfaces;

namespace UserVoice.Services.Data
{
    public class IdeasService : IIdeasService
    {
        private readonly IDbRepository<Idea> ideas;

        public IdeasService(IDbRepository<Idea> ideas)
        {
            this.ideas = ideas;
        }

        public IQueryable AllSorted()
        {
            return this.ideas
                .All()
                .OrderBy(i => i.Votes.Count)
                .ThenBy(i => i.CreatedOn);
        }

        public bool Add(string title, string description)
        {
            this.ideas.Add(new Idea { Title = title, Description = description });
            this.ideas.Save();

            return true;
        }

        public bool UpdateIdeaId(int id, int value)
        {
            var idea = this.ideas.GetById(id);

            idea.Votes.Add(new Vote() { VotePoints = value });

            this.ideas.Add(idea);
            this.ideas.Save();

            return true;
        }
    }
}
