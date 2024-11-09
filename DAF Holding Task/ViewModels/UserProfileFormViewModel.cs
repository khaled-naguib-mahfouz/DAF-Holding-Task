using System.ComponentModel.DataAnnotations;

namespace DAF_Holding_Task.ViewModels
{
    public class UserProfileFormViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "First Name is required")]
        [Display(Name = "First Name"), MaxLength(50)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last Name is required")]
        [Display(Name = "Last Name"), MaxLength(50)]
        public string LastName { get; set; }
        [Display(Name = "Date of birth")]
        [Required(ErrorMessage = "Date of birth is required")]
        public DateOnly DateOfBirth { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [MaxLength(128, ErrorMessage = "Email cannot exceed 128 characters")]
        public string Email { get; set; }
        public UserProfileFormViewModel()
        {
            DateOfBirth = new DateOnly(2000, 1, 1); 
        }
    }
}
