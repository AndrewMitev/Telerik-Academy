namespace MvcTemplate.Web.Areas.Administration.ViewModels
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using MvcTemplate.Data.Models;
    using MvcTemplate.Web.Infrastructure.Mapping;

    public class CommentAdminViewModel : IMapFrom<Comment>
    {
        public int Id { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public string AuthorEmail { get; set; }

        [Required]
        public string AuthorIP { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}