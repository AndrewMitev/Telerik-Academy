namespace MvcTemplate.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using MvcTemplate.Data.Common.Models;

    public class Vote : BaseModel<int>
    {
        public int IdeaId { get; set; }

        public virtual Idea Idea { get; set; }

        public string IP { get; set; }

        [Required]
        public int Points { get; set; }
    }
}
