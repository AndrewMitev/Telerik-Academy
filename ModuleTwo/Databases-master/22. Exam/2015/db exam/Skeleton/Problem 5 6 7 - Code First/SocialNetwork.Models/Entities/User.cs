namespace SocialNetwork.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class User
    {
        private ICollection<Post> posts;
        private ICollection<Image> images;

        public User()
        {
            this.posts = new HashSet<Post>();
            this.images = new HashSet<Image>();
        }

        [Key]
        public int UserId { get; set; }

        [Required]
        [MinLength(4)]
        [MaxLength(20)]
        public string Username { get; set; }

        [MinLength(2)]
        [MaxLength(50)]
        public string FirtsName { get; set;}


        [MinLength(2)]
        [MaxLength(50)]
        public string LastName { get; set; }

        public DateTime RegistrationDate { get; set; }

        //Many-to-Many Posts
        public virtual ICollection<Post> Posts
        {
            get
            {
                return this.posts;
            }
            set
            {
                this.posts = value;
            }
        }

        //One-To-Many Image
        public virtual ICollection<Image> Images
        {
            get
            {
                return this.images;
            }
            set
            {
                this.images = value;
            }
        }
    }
}
