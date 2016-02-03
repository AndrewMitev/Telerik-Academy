using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeSystem.Data.Repositories;
using YoutubeSystem.Models;
using YoutubeSystem.Services.Contracts;

namespace YoutubeSystem.Services
{
    public class PlaylistsServices : IPlaylistsServices
    {
        private IRepository<Playlist> playlists;

        public PlaylistsServices(IRepository<Playlist> playlists)
        {
            this.playlists = playlists;
        }

        public IQueryable<Playlist> GetTop(int count)
        {
            return this.playlists.All().Take(count);
        }

        public IQueryable<Playlist> GetMyPlaylists(string author_id)
        {
            return this.playlists.All().Where(p => p.AuthorId == author_id);
        }

        public Playlist GetById(int id)
        {
            return this.playlists.GetById(id);
        }

        public Playlist Create(Playlist newPlaylist)
        {
            this.playlists.Add(newPlaylist);

            this.playlists.SaveChanges();

            return newPlaylist;
        }

        public void DeleteById(int id)
        {
            this.playlists.Delete(id);
            this.playlists.SaveChanges();
        }
    }
}
