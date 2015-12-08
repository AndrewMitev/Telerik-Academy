namespace TeleImot.Data.Models
{
    using DataAnnotationsExtensions;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class RealEstate
    {
        private ICollection<Comment> comments;

        public RealEstate()
        {
            this.comments = new HashSet<Comment>();
        }

        public virtual ICollection<Comment> Comments
        {
            get { return this.comments; }
            set { this.comments = value; }
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(50)]
        public string Title { get; set; }

        [Required]
        [MinLength(10)]
        [MaxLength(1000)]
        public string Description { get; set; }

        public Type Type { get; set; }

        [Required]
        public SellOption SellOption { get; set; }

        [Min(1800)]
        public int ConstructionYear { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string Contact { get; set; }
    }
}
