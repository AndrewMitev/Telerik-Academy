namespace MvcTemplate.Web.Areas.Administration.Controllers
{
    using System.Linq;
    using System.Web.Mvc;

    using Infrastructure.Mapping;
    using Kendo.Mvc.Extensions;
    using Kendo.Mvc.UI;
    using Services.Data;
    using ViewModels;

    public class CommentsAdminController : AdministrationController
    {
        private ICommentsService comments;

        public CommentsAdminController(ICommentsService comments)
        {
            this.comments = comments;
        }

        public ActionResult Index()
        {
            return this.View();
        }

        [HttpPost]
        public JsonResult Read([DataSourceRequest]DataSourceRequest request)
        {
            var allComments = this.comments
                .GetAll()
                .To<CommentAdminViewModel>()
                .ToList();

            return this.Json(allComments.ToDataSourceResult(request), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult Edit([DataSourceRequest]DataSourceRequest request, CommentEditAdminViewModel model)
        {
            if (model != null && this.ModelState.IsValid)
            {
                this.comments.Update(model.Id, model.Content, model.AuthorEmail);
            }

            return this.Json(new[] { model }.ToDataSourceResult(request, this.ModelState));
        }

        public ActionResult Delete([DataSourceRequest] DataSourceRequest request, CommentEditAdminViewModel model)
        {
            if (model != null)
            {
                this.comments.Delete(model.Id);
            }

            return this.Json(new[] { model }.ToDataSourceResult(request, this.ModelState));
        }
    }
}