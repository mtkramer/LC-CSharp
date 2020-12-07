using System.ComponentModel.DataAnnotations;

namespace Studio15_ViewModel_Validation.ViewModels
{
    public class AddUserViewModel
    {
        [Required(ErrorMessage = "A username is required.")]
        [StringLength(15, MinimumLength = 5, ErrorMessage = "Valid usernames must be between 5 and 15 characters.")]
        public string Username { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "A password is required.")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Valid passwords must be between 6 and 20 characters.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Password verification is required.")]
        [Compare("Password", ErrorMessage = "Password and Confirm Password must match.")]
        public string VerifyPassword { get; set; }

    }
}
