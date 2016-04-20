namespace MvcTemplate.Web.ViewModels.Comments
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using Data.Models;
    using Infrastructure.Mapping;
    
    public class CommentViewModel : IMapFrom<Comment>
    {
        [Required]
        public string Content { get; set; }

        [Required]
        public string AuthorEmail { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}