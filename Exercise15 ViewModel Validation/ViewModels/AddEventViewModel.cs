using System.ComponentModel.DataAnnotations;

namespace Exercise15_ViewModel_Validation.ViewModels
{
    public class AddEventViewModel
    {
        [Required(ErrorMessage = "A name is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a description for your event.")]
        [StringLength(500, ErrorMessage = "Description is too long!")]
        public string Description { get; set; }

        [EmailAddress]
        public string ContactEmail { get; set; }

        [Required(ErrorMessage = "Event must have a location.")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Please enter the location of the event.")]
        public string Location { get; set; }

        [Range(0, 100000, ErrorMessage = "Event tickets must be between 0 and 100,000")]
        public int NumberOfTickets { get; set; }
    }
}
