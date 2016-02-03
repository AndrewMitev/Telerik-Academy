namespace YoutubeSystem.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Rating
    {
        public int Id { get; set; }

        //[Required]
        //public string UserId { get; set; }

        //[ForeignKey("UserId")]
        //public virtual User FromUser { get; set; }

        //[Required]
        //public int PlaylistId { get; set; }

        //[ForeignKey("PlaylistId")]
        //public virtual Playlist ToPlaylist { get; set; }

        [Range(typeof(int), "1", "5")]
        public int Value { get; set; }
    }
}
