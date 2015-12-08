namespace TeleImot.Server.Api.Models
{
    using System.ComponentModel.DataAnnotations;
    using Data.Models;
    using System.Linq.Expressions;
    using System;

    public class RealEstateResponseModel
    {
        public int Id { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(50)]
        public string Title { get; set; }

        [Required]
        [MinLength(10)]
        [MaxLength(1000)]
        public string Description { get; set; }

        public static Expression<Func<RealEstate, RealEstateResponseModel>> FromModel
        {
            get
            {
                return r => new RealEstateResponseModel
                {
                    Id = r.Id,
                    Description = r.Description,
                    Title = r.Title
                };
            }
        }
    }
}