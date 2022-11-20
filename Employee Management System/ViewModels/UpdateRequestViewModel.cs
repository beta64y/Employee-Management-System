using System.ComponentModel.DataAnnotations;

namespace Employee_Management_System.ViewModels
{
    public class UpdateRequestViewModel
    {
        [Required]
        [RegularExpression(@"^(?=[A-Z]{1})([A-Za-z]{3,20})$", ErrorMessage = "Name is not Wrong")]
        public string Name { get; set; }

        [Required]
        [RegularExpression(@"^(?=[A-Z]{1})([A-Za-z]{3,20})$", ErrorMessage = "Surname is not Wrong")]
        public string Surname { get; set; }

        [Required]
        [RegularExpression(@"^(?=[A-Z]{1})([A-Za-z]{3,20})$", ErrorMessage = "FatherName is Wrong")]
        public string FatherName { get; set; }

        [Required]
        [RegularExpression(@"^[A-Z0-9]{0,7}$", ErrorMessage = "FIN is Wrong")]
        public string FIN { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Email is Wrong")]
        public string Email { get; set; }
    }
}
