namespace TeleImot.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Comment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(10)]
        [MaxLength(50)]
        public string Content { get; set; }

        public DateTime CommentedOn { get; set; }

        public int UserId { get; set; }

        public virtual User User { get; set; }

        public int RealEstateId {get; set; }

        public virtual RealEstate RealEstateCommented { get; set; }
    }
}
