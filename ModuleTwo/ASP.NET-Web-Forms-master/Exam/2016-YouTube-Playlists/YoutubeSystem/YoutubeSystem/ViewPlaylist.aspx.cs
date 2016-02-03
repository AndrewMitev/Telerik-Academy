using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;
using YoutubeSystem.Models;
using YoutubeSystem.Services.Contracts;

namespace YoutubeSystem
{
    public partial class ViewPlaylist : System.Web.UI.Page
    {
        [Inject]
        public IPlaylistsServices playlistsServices { get; set; }


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // The id parameter should match the DataKeyNames value set on the control
        // or be decorated with a value provider attribute, e.g. [QueryString]int id
        public Playlist playlistFormView_GetItem([QueryString]string id)
        {
            var playlists = this.playlistsServices.GetById(int.Parse(id));

            if (playlists != null)
            {
                return playlists;
            }

            return null;
        }
    }
}