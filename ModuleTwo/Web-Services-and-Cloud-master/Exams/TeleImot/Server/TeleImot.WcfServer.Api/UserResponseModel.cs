namespace TeleImot.WcfServer.Api
{
    using System;
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Data.Models;

    [DataContract]
    public class UserResponseModel
    {
        public static Expression<Func<User, UserResponseModel>> FromUser
        {
            get
            {
                return user => new UserResponseModel()
                {
                    Username = user.UserName,
                    Rating = user.Rating
                };
            }
        }

        [DataMember]
        public string Username { get; private set; }

        [DataMember]
        public int Rating { get; private set; }
    }
}