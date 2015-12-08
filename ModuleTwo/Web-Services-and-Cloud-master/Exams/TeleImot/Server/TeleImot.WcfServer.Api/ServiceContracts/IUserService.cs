namespace TeleImot.WcfServer.Api.ServiceContracts
{
    using System.Linq;
    using System.ServiceModel;
    using Data.Models;

    [ServiceContract]
    public interface IUserService
    {

        [OperationContract]
        IQueryable<UserResponseModel> GetTopUsers();
    }
}
