using System.ComponentModel.DataAnnotations;
using Employee_Management_System.Services;
using Employee_Management_System.ViewModels.Common;
namespace Employee_Management_System.ViewModels

{
    public class AddViewModel : BaseViewModel
    {
       
        [Required]
        public bool IsDeleted { get; set; }

    }
}
