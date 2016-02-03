using Countries.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Countries
{
    public partial class Showcase : System.Web.UI.Page
    {
        ApplicationDbContext context;

        public Showcase()
        {
            this.context = new ApplicationDbContext();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Continent> GetContinents()
        {
            return this.context.Continents.OrderBy(x => x.Id);
        }

        public IQueryable<Country> GetCountries()
        {
            return this.context.Countries.OrderBy(c => c.Id);
        }

        public IQueryable<Town> GetTowns()
        {
            return this.context.Towns.OrderBy(c => c.Id);
        }
    }
}