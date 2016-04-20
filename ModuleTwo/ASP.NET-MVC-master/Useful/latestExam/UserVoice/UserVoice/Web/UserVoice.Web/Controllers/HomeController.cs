namespace UserVoice.Web.Controllers
{
    using Data.Models;
    using UserVoice.Web.Infrastructure.Mapping;
    using Services.Data.Interfaces;
    using System;
    using System.Diagnostics;
    using System.IO;
    using System.Linq;
    using System.Web.Mvc;
    using ViewModels.IdeaViewModels;
    public class HomeController : BaseController
    {
        private IIdeasService ideasService;

        public HomeController(IIdeasService ideasService)
        {
            this.ideasService = ideasService;
        }

        public ActionResult Index()
        {
            //var jokes = this.Cache.Get("jokes", () => votesService.All().To<JokeViewModel>().ToList(), 3 * 60);
            var votes = this.ideasService.AllSorted().To<IdeaViewModel>().ToList();
            return View(votes);
        }

        [ValidateAntiForgeryToken]
        public ActionResult PostIdea(IdeaViewModel idea)
        {
            if (ModelState.IsValid)
            {
                this.ideasService.Add(idea.Title, idea.Description);
                return this.View("_SuccessIdeaAdd");
            }

            return this.RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult UpdateIdeaVotes(int ideaId, int value)
        {
            if (this.ideasService.UpdateIdeaId(ideaId, value))
            {
                return this.View("_SuccessVotePartial");
            }

            return this.View("_ErrorVotePartial");
        }
    }
}