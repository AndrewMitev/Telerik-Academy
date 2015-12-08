namespace SocialNetwork.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class ChatMessage
    {
        [Key]
        public int ChatMessageId { get; set; }

        [ForeignKey("Friendship")]
        public int FriendshipId { get; set; }

        public virtual Friendship Friendship { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

        public virtual User User { get; set; }

        [Required]
        public string Content { get; set; }

        [Index]
        public DateTime DateOfSending { get; set; }

        public DateTime DateOfSeen { get; set; }
    }
}
