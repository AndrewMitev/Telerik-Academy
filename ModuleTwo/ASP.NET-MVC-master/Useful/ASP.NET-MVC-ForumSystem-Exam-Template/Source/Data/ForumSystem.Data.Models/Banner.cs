using ForumSystem.Data.Common.Models;
using System.ComponentModel.DataAnnotations;
using System;

namespace ForumSystem.Data.Models
{
    public class Banner : IDeletableEntity
    {
        [Key]
        public int Id { get; set; }

        public string ImageUrl { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

    }
}
