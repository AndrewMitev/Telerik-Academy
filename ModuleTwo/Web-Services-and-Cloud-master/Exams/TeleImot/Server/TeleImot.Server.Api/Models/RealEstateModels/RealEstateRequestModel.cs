namespace TeleImot.Server.Api.Models
{
    using DataAnnotationsExtensions;
    using System.ComponentModel.DataAnnotations;

    public class RealEstateRequestModel
    {
        [MinLength(5)]
        [MaxLength(50)]
        public string Title { get; set; }

        [MinLength(10)]
        [MaxLength(1000)]
        public string Description { get; set; }

        public string Address { get; set; }

        public string Contact { get; set; }

        [Min(1800)]
        public int ConstructionYear { get; set; }

        public int SellingPrice { get; set; }

        public int RentingPrice { get; set; }

        public Type Type { get; set; }
    }
}