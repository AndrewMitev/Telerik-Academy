namespace MvcTemplate.Web.ViewModels.Ideas
{
    using System.Linq;

    using AutoMapper;
    using MvcTemplate.Data.Models;
    using MvcTemplate.Web.Infrastructure.Mapping;

    public class IdeaViewModel : IMapFrom<Idea>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string AuthorIP { get; set; }

        public string AuthorId { get; set; }

        public int Votes { get; set; }

        public int CommentsCount { get; set; }

        public void CreateMappings(IMapperConfiguration configuration)
        {
            configuration.CreateMap<Idea, IdeaViewModel>()
                .ForMember(x => x.Votes, opt => opt.MapFrom(i => i.Votes.Any() ? i.Votes.Sum(v => v.Points) : 0));

            configuration.CreateMap<Idea, IdeaViewModel>()
                .ForMember(x => x.CommentsCount, opt => opt.MapFrom(i => i.Comments.Count));
        }
    }
}