namespace TeleImot.Server.Api.Controllers
{
    using System.Web.Http;
    using Services.Contracts;
    using Models;

    public class UsersController : ApiController
    {
        private IUserServices userServices;

        public UsersController(IUserServices userServices)
        {
            this.userServices = userServices;
        }

        public IHttpActionResult Get(string username)
        {
            return this.Ok(this.userServices.Get(username));
        }

        public IHttpActionResult Put(UserRequestModel userRequest)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest("Invalid Id and Value");
            }

            this.userServices.UpdateRate(int.Parse(userRequest.UserId), int.Parse(userRequest.Value));

            return this.Ok();
        }
    }
}
