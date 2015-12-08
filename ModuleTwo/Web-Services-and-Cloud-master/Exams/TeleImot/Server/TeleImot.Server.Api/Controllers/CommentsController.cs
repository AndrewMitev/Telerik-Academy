namespace TeleImot.Server.Api.Controllers
{
    using System.Web.Http;
    using Services.Contracts;
    using Common;
    using Models;

    public class CommentsController : ApiController
    {
        private ICommentsServices commentsServices;

        public CommentsController(ICommentsServices commentsServices)
        {
            this.commentsServices = commentsServices;
        }

        [Authorize]
        public IHttpActionResult Get(int id)
        {
            var comments = this.commentsServices
                .GetByRealEstateId(id);

            return this.Ok(comments);
        }

        [Authorize]
        public IHttpActionResult Get(int id, int skip, int take)
        {
            if (take > GlobalConstants.TakeMaxValue)
            {
                return this.BadRequest(string.Format("Take cannot be more than {0}", GlobalConstants.TakeMaxValue));
            }

            var comments = this.commentsServices
                .GetByRealEstateId(id, skip, take);

            return this.Ok(comments);
        }

        [Authorize]
        [Route("ByUser")]
        public IHttpActionResult Get(string username)
        {
            var comments = this.commentsServices.CommentsByUser(username);

            return this.Ok(comments);
        }

        [Authorize]
        [Route("ByUser")]
        public IHttpActionResult Get(string username, int skip, int take)
        {
            var comments = this.commentsServices.CommentsByUser(username, skip, take);

            return this.Ok(comments);
        }

        [Authorize]
        public IHttpActionResult Post(CommentsRequestModel request)
        {
            var comment = this.commentsServices.Add(request.RealEstateId, request.Content);

            return this.Ok(comment);
        }
    }
}
