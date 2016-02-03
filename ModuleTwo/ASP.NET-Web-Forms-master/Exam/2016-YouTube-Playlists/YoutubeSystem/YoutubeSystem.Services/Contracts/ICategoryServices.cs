using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeSystem.Models;

namespace YoutubeSystem.Services.Contracts
{
    public interface ICategoryServices
    {
        IQueryable<Category> GetAll();
    }
}
