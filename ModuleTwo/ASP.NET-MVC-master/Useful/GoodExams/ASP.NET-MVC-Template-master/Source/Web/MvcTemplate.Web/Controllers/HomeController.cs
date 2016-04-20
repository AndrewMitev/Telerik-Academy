namespace MvcTemplate.Web.Controllers
{
    using System;
    using System.Linq;
    using System.Web.Mvc;

    using Common;
    using Infrastructure.Mapping;
    using Microsoft.AspNet.Identity;
    using Services.Data;
    using ViewModels.Ideas;

    public class HomeController : BaseController
    {
        private const int DefaultIdeasPageSize = GlobalConstants.IdeasDefaultPageSize;
        private IIdeaService ideas;

        public HomeController(IIdeaService ideas)
        {
            this.ideas = ideas;
        }

        public ActionResult Index(int page = 1)
        {
            int totalIdeas = this.ideas.GetAll().Count();
            int totalPages = (int)Math.Ceiling(totalIdeas / (decimal)DefaultIdeasPageSize);

            var ideasResult = this.Cache.Get(page.ToString(),
                            () => this.ideas
                                .GetAll(page)
                                .To<IdeaViewModel>()
                                .ToList(),
                            1 * 60);

            IdeaListViewModel viewModel = new IdeaListViewModel()
            {
                CurrentPage = page,
                TotalPages = totalPages,
                Ideas = ideasResult
            };

            return this.View(viewModel);
        }

        [HttpGet]
        public ActionResult GetIdeaDescription(int id)
        {
            var ideaDescription = this.ideas.GetById(id).Description;

            return this.Content(ideaDescription);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return this.PartialView("_CreateIdeaPartial");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateIdeaViewModel model)
        {
            if (!this.ModelState.IsValid)
            {
                this.View(model);
            }

            if (this.User.Identity.IsAuthenticated)
            {
                this.ideas.Add(model.Title, model.Description, this.Request.UserHostAddress, this.User.Identity.GetUserId());
            }
            else
            {
                this.ideas.Add(model.Title, model.Description, this.Request.UserHostAddress, null);
            }

            this.TempData["notification"] = "Idea created";

            return this.RedirectToAction("Index");
        }
    }
}
