using System;
using ForumSystem.Data.Common.Models;
using System.ComponentModel.DataAnnotations;

namespace ForumSystem.Data.Models
{
    public class TextAd : IDeletableEntity
    {
        [Key]
        public int Id { get; set; }

        public string Text { get; set; }

        public DateTime? DeletedOn { get; set; }

        public bool IsDeleted { get; set; }

    }
}
