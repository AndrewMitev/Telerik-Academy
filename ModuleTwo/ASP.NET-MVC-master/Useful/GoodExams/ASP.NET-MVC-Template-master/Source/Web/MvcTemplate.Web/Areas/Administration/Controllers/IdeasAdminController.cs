namespace MvcTemplate.Web.Areas.Administration.Controllers
{
    using System.Linq;
    using System.Web.Mvc;

    using Kendo.Mvc.Extensions;
    using Kendo.Mvc.UI;
    using MvcTemplate.Services.Data;
    using MvcTemplate.Web.Areas.Administration.ViewModels;
    using MvcTemplate.Web.Infrastructure.Mapping;

    public class IdeasAdminController : AdministrationController
    {
        private IIdeaService ideas;

        public IdeasAdminController(IIdeaService ideas)
        {
            this.ideas = ideas;
        }

        public ActionResult Index()
        {
            return this.View();
        }

        [HttpPost]
        public JsonResult Read([DataSourceRequest]DataSourceRequest request)
        {
            var allideas = this.ideas
                .GetAll()
                .To<IdeaAdminViewModel>()
                .ToList();

            return this.Json(allideas.ToDataSourceResult(request), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult Edit([DataSourceRequest]DataSourceRequest request, IdeaEditAdminViewModel model)
        {
            if (model != null && this.ModelState.IsValid)
            {
                this.ideas.Update(model.Id, model.Title, model.Description);
            }

            return this.Json(new[] { model }.ToDataSourceResult(request, this.ModelState));
        }

        public ActionResult Delete([DataSourceRequest] DataSourceRequest request, IdeaEditAdminViewModel model)
        {
            if (model != null)
            {
                this.ideas.Delete(model.Id);
            }

            return this.Json(new[] { model }.ToDataSourceResult(request, this.ModelState));
        }
    }
}