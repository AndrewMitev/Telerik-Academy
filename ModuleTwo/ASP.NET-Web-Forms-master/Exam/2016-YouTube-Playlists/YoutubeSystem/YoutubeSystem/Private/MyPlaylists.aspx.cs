using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using YoutubeSystem.Services.Contracts;
using Microsoft.AspNet.Identity;
using YoutubeSystem.Models;

namespace YoutubeSystem.Private
{
    public partial class MyPlaylists : System.Web.UI.Page
    {
        [Inject]
        public IPlaylistsServices playlistsServices { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IEnumerable<Playlist> myPlaylistsView_GetData()
        {
            return this.playlistsServices.GetMyPlaylists(User.Identity.GetUserId());
        }

        public void myPlaylistsView_DeleteItem(int id)
        {
            this.playlistsServices.DeleteById(id);
        }
    }
}