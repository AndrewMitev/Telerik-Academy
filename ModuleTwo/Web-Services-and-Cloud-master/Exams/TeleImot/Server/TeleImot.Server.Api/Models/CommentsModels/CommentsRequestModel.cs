namespace TeleImot.Server.Api.Models
{
    using System.ComponentModel.DataAnnotations;

    public class CommentsRequestModel
    {
        public int RealEstateId { get; set; }

        [MinLength(10)]
        [MaxLength(50)]
        public string Content { get; set; }
    }
}