namespace ForumSystem.Web.Controllers
{
    using System.Web.Mvc;

    using AutoMapper.QueryableExtensions;

    using ForumSystem.Data.Common.Repository;
    using ForumSystem.Data.Models;
    using ForumSystem.Web.ViewModels.Home;

    public class HomeController : Controller
    {
        private readonly IDeletableEntityRepository<Post> posts;
        private readonly IDeletableEntityRepository<TextAd> ads;
        private readonly IDeletableEntityRepository<Banner> banners;

        public HomeController(IDeletableEntityRepository<Post> posts, IDeletableEntityRepository<TextAd> ads, IDeletableEntityRepository<Banner> banners)
        {
            this.posts = posts;
            this.ads = ads;
            this.banners = banners;
        }

        public ActionResult Index()
        {
            var model = this.posts.All().Project().To<IndexBlogPostViewModel>();
            var ads = this.ads.All().Project().To<TextAdViewModel>();
            var banners = this.banners.All().Project().To<BannerViewModel>();
            var data = new PostsAndTextAddsViewModel
            {
                Posts = model,
                TextAds = ads,
                Banners = banners
            };

            return this.View(data);
        }
    }
}