using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace DAF_Holding_Task.ViewModels
{
    public class PostFormViewModel
    {
        [Required(ErrorMessage = "Title is required.")]
        [MaxLength(500, ErrorMessage = "Title cannot exceed 500 characters.")]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Display(Name = "Content")]
        public string Content { get; set; }

        [Required(ErrorMessage = "Date Posted is required.")]
        [Display(Name = "Date Posted")]
        public DateOnly DatePosted { get; set; } = DateOnly.FromDateTime(DateTime.Today); // Default to today’s date

        [Required(ErrorMessage = "User Profile is required.")]
        [Display(Name = "User Profile ID")]
        public int UserProfileID { get; set; }
        public IEnumerable<SelectListItem> UserProfiles { get; set; }

    }
}
