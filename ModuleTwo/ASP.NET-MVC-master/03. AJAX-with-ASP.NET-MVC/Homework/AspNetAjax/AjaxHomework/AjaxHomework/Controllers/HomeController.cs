namespace AjaxHomework.Controllers
{
    using AjaxHomework.Models;
    using System.Linq;
    using System.Web.Mvc;

    // Hamalskata!
    public class HomeController : Controller
    {
        private ApplicationDbContext context;

        public HomeController()
        {
            this.context = new ApplicationDbContext();
        }

        public ActionResult Index()
        {
            return View(this.context.Movies.ToList());
        }

        [HttpPost]
        public ActionResult Create(string title, string year)
        {
            if (this.ModelState.IsValid)
            {
                var movie = new Movie
                {
                    Title = title,
                    Year = short.Parse(year)
                };

                this.context.Movies.Add(movie);
                this.context.SaveChanges();
            }

            var all = this.context.Movies.ToList();

            //can't figure out why isn't it replacing 
            return this.PartialView("_MovieResult", all);
        }

        public ActionResult Update(Movie movieTemp)
        {
            var movie = this.context.Movies.FirstOrDefault(m => m.Id == movieTemp.Id);
            this.context.Movies.Remove(movie);
            this.context.Movies.Add(movieTemp);

            this.context.SaveChanges();

            return View("Success");
        }

        public ActionResult Delete(Movie movieTemp)
        {
            var movie = this.context.Movies.FirstOrDefault(m => m.Id == movieTemp.Id);
            this.context.Movies.Remove(movie);

            this.context.SaveChanges();

            return View("Success");
        }
    }
}