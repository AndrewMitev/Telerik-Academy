namespace TeleImot.Data
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using System.Data.Entity;
    using TeleImot.Data.Models;

    public class TeleImotDbContext : IdentityDbContext<User>, ITeleImotDbContext
    {
        public TeleImotDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static TeleImotDbContext Create()
        {
            return new TeleImotDbContext();
        }

        public virtual IDbSet<RealEstate> RealEstates { get; set; }

        public virtual IDbSet<Comment> Comments { get; set; }
    }
}
