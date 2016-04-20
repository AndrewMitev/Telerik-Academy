namespace MvcTemplate.Web.Areas.Administration.ViewModels
{
    using System.ComponentModel.DataAnnotations;

    public class CommentEditAdminViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public string AuthorEmail { get; set; }
    }
}