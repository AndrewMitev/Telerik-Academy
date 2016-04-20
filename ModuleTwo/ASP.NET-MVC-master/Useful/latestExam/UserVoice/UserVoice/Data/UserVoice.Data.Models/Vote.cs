namespace UserVoice.Data.Models
{
    using System.ComponentModel.DataAnnotations.Schema;
    using UserVoice.Data.Common.Models;

    public class Vote : BaseModel<int>
    {
        public int VotePoints { get; set; }

        public string AuthorIp { get; set; }

        //[ForeignKey("AuthorIp")]
        //public ApplicationUser User { get; set; }
    }
}
