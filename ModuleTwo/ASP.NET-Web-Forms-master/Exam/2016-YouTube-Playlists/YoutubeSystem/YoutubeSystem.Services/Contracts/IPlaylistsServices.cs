using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeSystem.Models;

namespace YoutubeSystem.Services.Contracts
{
    public interface IPlaylistsServices
    {
        IQueryable<Playlist> GetTop(int count);

        Playlist GetById(int id);

        Playlist Create(Playlist newPlaylist);

        IQueryable<Playlist> GetMyPlaylists(string author_id);

        void DeleteById(int id);

    }
}
