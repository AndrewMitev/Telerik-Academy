namespace MvcTemplate.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using MvcTemplate.Data.Common.Models;

    public class Comment : BaseModel<int>
    {
        [Required]
        public string Content { get; set; }

        [Required]
        public string AuthorEmail { get; set; }

        [Required]
        public string AuthorIP { get; set; }

        public int IdeaId { get; set; }

        public virtual Idea Idea { get; set; }
    }
}
