using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using YoutubeSystem.Models;
using YoutubeSystem.Services.Contracts;

namespace YoutubeSystem
{
    public partial class Home : System.Web.UI.Page
    {
        public const int TopPlaylistsCount = 10;

        [Inject]
        public IPlaylistsServices playlistsServices { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IEnumerable<Playlist> playlistsRepeater_GetData()
        {
            return playlistsServices.GetTop(TopPlaylistsCount);
        }
    }
}