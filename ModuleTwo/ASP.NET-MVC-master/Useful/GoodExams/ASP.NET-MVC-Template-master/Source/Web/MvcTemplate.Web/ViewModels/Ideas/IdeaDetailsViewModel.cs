namespace MvcTemplate.Web.ViewModels.Ideas
{
    using System.Collections.Generic;
    using System.Linq;

    using AutoMapper;
    using Comments;

    using MvcTemplate.Data.Models;
    using MvcTemplate.Web.Infrastructure.Mapping;

    public class IdeaDetailsViewModel : IMapFrom<Idea>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string AuthorIP { get; set; }

        public string AuthorId { get; set; }

        public int Votes { get; set; }

        public IEnumerable<CommentViewModel> Comments { get; set; }

        public void CreateMappings(IMapperConfiguration configuration)
        {
            configuration.CreateMap<Idea, IdeaDetailsViewModel>()
                .ForMember(x => x.Votes, opt => opt.MapFrom(i => i.Votes.Any() ? i.Votes.Sum(v => v.Points) : 0));

            configuration.CreateMap<Idea, IdeaDetailsViewModel>()
                .ForMember(x => x.Comments, opt => opt.MapFrom(i => i.Comments.Select(c => new CommentViewModel { Content = c.Content, AuthorEmail = c.AuthorEmail, CreatedOn = c.CreatedOn })));
        }
    }
}