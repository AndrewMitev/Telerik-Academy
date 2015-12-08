namespace SocialNetwork.Models.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Friendship
    {
        [Key]
        public int FriendshipId { get; set; }

        [ForeignKey("User")]
        public int FirstUserId { get; set; }

        public virtual User FirstUser { get; set; }

        [ForeignKey("User")]
        public int SecondUserId { get; set; }

        public virtual User SecondUser { get; set; }

        [Index]
        public bool IsApproved { get; set; }

        public DateTime DateOfApprovedFriendship { get; set; }
    }
}
