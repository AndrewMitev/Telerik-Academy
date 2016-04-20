namespace MvcTemplate.Web.Controllers
{
    using System.Linq;
    using System.Web.Mvc;

    using Services.Data;
    using Infrastructure.Mapping;
    using ViewModels.Ideas;

    public class IdeasController : BaseController
    {
        private IIdeaService ideas;

        public IdeasController(IIdeaService ideas)
        {
            this.ideas = ideas;
        }

        public ActionResult Details(int id)
        {
            var idea = this.ideas
                .GetAll()
                .To<IdeaDetailsViewModel>()
                .FirstOrDefault(i => i.Id == id);

            return this.View(idea);
        }
    }
}