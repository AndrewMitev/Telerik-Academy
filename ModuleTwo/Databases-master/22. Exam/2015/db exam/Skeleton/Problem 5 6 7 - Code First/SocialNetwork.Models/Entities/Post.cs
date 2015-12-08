namespace SocialNetwork.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Post
    {
        private ICollection<User> users;

        public Post()
        {
            this.users = new HashSet<User>();
        }

        [Key]
        public int PostId { get; set; }

        [Required]
        [MinLength(10)]
        public string Content { get; set; }

        public DateTime PostingDate { get; set; }

        //Many-to-Many User
        public virtual ICollection<User> Users
        {
            get
            {
                return this.users;
            }
            set
            {
                this.users = value;
            }
        }
    }
}
