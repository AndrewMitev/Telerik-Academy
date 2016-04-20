using ForumSystem.Data.Models;
using ForumSystem.Web.Infrastructure.Mapping;

namespace ForumSystem.Web.ViewModels.Home
{
    public class TextAdViewModel : IMapFrom<TextAd>
    {
        public string Text { get; set; }
    }
}