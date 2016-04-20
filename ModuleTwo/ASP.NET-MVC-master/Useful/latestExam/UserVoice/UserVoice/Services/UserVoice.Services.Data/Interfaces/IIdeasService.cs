using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserVoice.Data.Models;

namespace UserVoice.Services.Data.Interfaces
{
    public interface IIdeasService
    {
        IQueryable AllSorted();

        bool Add(string title, string description);

        bool UpdateIdeaId(int id, int value);
    }
}
