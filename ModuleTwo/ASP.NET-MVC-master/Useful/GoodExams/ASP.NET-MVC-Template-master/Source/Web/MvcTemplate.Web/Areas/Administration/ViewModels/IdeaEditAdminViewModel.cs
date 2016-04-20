namespace MvcTemplate.Web.Areas.Administration.ViewModels
{
    using System.ComponentModel.DataAnnotations;

    public class IdeaEditAdminViewModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }
    }
}