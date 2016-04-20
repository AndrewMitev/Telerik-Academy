using UserVoice.Data.Models;
using System.Linq;

namespace UserVoice.Services.Data.Interfaces
{
    public interface IVotesService
    {
        IQueryable<Vote> All();
    }
}