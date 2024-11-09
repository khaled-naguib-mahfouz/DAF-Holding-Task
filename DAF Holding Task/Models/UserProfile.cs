using System.ComponentModel.DataAnnotations;

namespace DAF_Holding_Task.Models
{
    public class UserProfile
    {
        public int Id { get; set; }
        [Required, MaxLength(50)]
        public string FirstName { get; set; }
        [Required, MaxLength(50)]
        public string LastName { get; set; }
        public DateOnly DateOfBirth { get; set; }
        [Required, MaxLength(128)]
        public string Email { get; set; }
        public ICollection<Post> posts { get; set; }
    }
}
