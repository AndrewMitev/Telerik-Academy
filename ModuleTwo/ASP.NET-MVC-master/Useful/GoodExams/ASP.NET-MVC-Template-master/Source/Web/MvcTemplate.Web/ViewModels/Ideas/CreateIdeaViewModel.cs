namespace MvcTemplate.Web.ViewModels.Ideas
{
    using System.ComponentModel.DataAnnotations;

    public class CreateIdeaViewModel
    {
        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }
    }
}