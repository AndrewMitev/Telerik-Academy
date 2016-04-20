namespace UserVoice.Web.ViewModels.IdeaViewModels
{
    using System;
    using AutoMapper;
    using UserVoice.Data.Models;
    using UserVoice.Web.Infrastructure.Mapping;
    using System.Web.Mvc;
    public class IdeaViewModel : IMapFrom<Idea>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int Votes { get; set; }

        public int CommentsCount { get; set; }

        public void CreateMappings(IMapperConfiguration configuration)
        {
            configuration.CreateMap<Idea, IdeaViewModel>()
                .ForMember(x => x.Votes, opt => opt.MapFrom(x => x.Votes.Count));

            configuration.CreateMap<Idea, IdeaViewModel>()
             .ForMember(x => x.CommentsCount, opt => opt.MapFrom(x => x.Comments.Count));
        }
    }
}