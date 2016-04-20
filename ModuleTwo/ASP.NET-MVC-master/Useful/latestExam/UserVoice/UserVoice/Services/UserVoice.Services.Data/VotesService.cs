using UserVoice.Data.Common;
using UserVoice.Data.Models;
using UserVoice.Services.Data.Interfaces;
using UserVoice.Services.Web;
using System.Linq;

namespace UserVoice.Services.Data
{
    public class VotesService : IVotesService
    {
        private IDbRepository<Vote> votes;
        private ICacheService Cache;

        public VotesService(IDbRepository<Vote> votes, ICacheService Cache)
        {
            this.votes = votes;
            this.Cache = Cache;
        }

        public IQueryable<Vote> All()
        {
            return this.votes.All();
        }
    }
}
