namespace UserVoice.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using UserVoice.Data.Common.Models;

    public class Idea : BaseModel<int>
    {
        public Idea()
        {
            this.Votes = new HashSet<Vote>();
            this.Comments = new HashSet<Comment>();
        }

        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        public string AuthorIp
        {
            get
            {
                if (this.User != null)
                {
                    return this.User.Ip;
                }

                return "empty";
            }
            set
            {
                if (this.User != null)
                {
                    this.User.Ip = value;
                }
            }
        }

        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }

        public virtual ICollection<Vote> Votes { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
    }
}
