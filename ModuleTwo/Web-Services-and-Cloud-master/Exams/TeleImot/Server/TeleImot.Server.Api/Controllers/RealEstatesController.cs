namespace TeleImot.Server.Api.Controllers
{
    using System.Web.Http;
    using Services.Contracts;
    using Models;
    using System.Linq;

    public class RealEstatesController : ApiController
    {
        private IRealEstateServices realEstateServices;

        public RealEstatesController(IRealEstateServices realEstateServices)
        {
            this.realEstateServices = realEstateServices;
        }

        public IHttpActionResult Get()
        {
            var estates = this.realEstateServices
                .All()
                .Select(RealEstateResponseModel.FromModel)
                .ToList();
                

            return this.Ok(estates);
        }

        public IHttpActionResult Get(int skip, int take)
        {
            var estates = this.realEstateServices.All(skip, take);

            return this.Ok(estates);
        }

        public IHttpActionResult Get(int id)
        {
            // TODO: check if logged display more
            var responseEstate = this.realEstateServices.GetSpecific(id);

            return this.Ok(responseEstate);
        }

        [Authorize]
        public IHttpActionResult Post(RealEstateRequestModel request)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest("Invalid model");
            }

            var estateId = this.realEstateServices.Add(
                request.Title,
                request.Description,
                request.Address,
                request.Contact,
                request.ConstructionYear,
                (int)request.Type);

            return this.Created("api/RealEstates", estateId);
        }
    }
}
