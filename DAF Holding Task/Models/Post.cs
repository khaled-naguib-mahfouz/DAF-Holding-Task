using System.ComponentModel.DataAnnotations;

namespace DAF_Holding_Task.Models
{
    public class Post
    {
        public int Id { get; set; }
        //foreign key for userprofile entity
        public int UserProfileID { get; set; }
        [Required, MaxLength(500)]
        public string Title { get; set; }
        public string Content { get; set; }
        public DateOnly DatePosted { get; set; }
        public UserProfile UserProfile { get; set; }
    }
}
