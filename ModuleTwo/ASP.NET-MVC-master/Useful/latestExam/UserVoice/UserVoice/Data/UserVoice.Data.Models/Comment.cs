namespace UserVoice.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
    using UserVoice.Data.Common.Models;

    public class Comment : BaseModel<int>
    {
        public string Content { get; set; }

        public string AuthorEmail { get; set; }

        public string AuthorIp { get; set; }

        //[ForeignKey("AuthorIp")]
        //public ApplicationUser User { get; set; }
    }
}
