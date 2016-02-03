using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeSystem.Data.Repositories;
using YoutubeSystem.Models;
using YoutubeSystem.Services.Contracts;

namespace YoutubeSystem.Services
{
    public class CategoryServices : ICategoryServices
    {
        private IRepository<Category> categories;

        public CategoryServices(IRepository<Category> categories)
        {
            this.categories = categories;
        }

        public IQueryable<Category> GetAll()
        {
            return this.categories.All();
        }
    }
}
