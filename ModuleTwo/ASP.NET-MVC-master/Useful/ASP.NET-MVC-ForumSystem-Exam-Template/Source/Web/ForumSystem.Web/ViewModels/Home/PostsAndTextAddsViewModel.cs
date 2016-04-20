using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ForumSystem.Web.ViewModels.Home
{
    public class PostsAndTextAddsViewModel
    {
        public IEnumerable<IndexBlogPostViewModel> Posts { get; set; }

        public IEnumerable<TextAdViewModel> TextAds {get;set;}

        public IEnumerable<BannerViewModel> Banners { get; set; }
    }
}