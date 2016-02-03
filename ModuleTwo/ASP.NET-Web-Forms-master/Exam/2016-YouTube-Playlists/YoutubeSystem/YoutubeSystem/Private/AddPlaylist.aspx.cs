using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;
using YoutubeSystem.Models;
using YoutubeSystem.Services.Contracts;

namespace YoutubeSystem.Private
{
    public partial class AddPlaylist : System.Web.UI.Page
    {
        [Inject]
        public IPlaylistsServices playlistServices { get; set; }

        [Inject]
        public ICategoryServices categoryServices { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void addPlaylistView_InsertItem()
        {
            var item = new Playlist();
            item.DateCreated = DateTime.Now;
            item.AuthorId = User.Identity.GetUserId();

            TryUpdateModel(item);

            if (ModelState.IsValid)
            {
                this.playlistServices.Create(item);
            }
        }

        public IQueryable<Category> insertCategory_GetData()
        {
            return this.categoryServices.GetAll();
        }

        public IQueryable<Playlist> addPlaylistView_GetData()
        {
            return this.playlistServices.GetTop(10);
        }
    }
}