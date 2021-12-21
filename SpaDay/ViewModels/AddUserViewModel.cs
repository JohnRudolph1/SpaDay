using System.ComponentModel.DataAnnotations;

namespace SpaDay.Models
{
    public class AddUserViewModel
    {
        [Required(ErrorMessage = "Username is required")]
        [StringLength(15, MinimumLength = 5, ErrorMessage = "Must be between 5 and 15 characters.")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [Range(6, 20, ErrorMessage = "Password must be between 6 and 20 characters")]
        public string Password { get; set; }
        [Required(ErrorMessage = "You must verify your password")]
        public string VerifyPassword { get; set; }
        [EmailAddress]
        public string Email { get; set; }
    }
}
