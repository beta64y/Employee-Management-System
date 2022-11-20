using System.ComponentModel.DataAnnotations;
using Employee_Management_System.Services;
namespace Employee_Management_System.Services
{
    public class FINValidation  : ValidationAttribute
    {
        public FINValidation()
            : base("{0} contains invalid character.")
        {

        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            
            if (value != null)
            {
                var newtext = value.ToString();
                Console.WriteLine(newtext);

                if (newtext.Length == 7 && StringValidationTools.isHaveUpperLetter(newtext) && StringValidationTools.isHaveNumber(newtext))
                {
                    
                    if (!(StringValidationTools.ASCIIInterval(newtext , 65 , 90) || StringValidationTools.ASCIIInterval(newtext,49,57)))
                    {
                        var errorMessage = FormatErrorMessage(validationContext.DisplayName);
                        return new ValidationResult(errorMessage);
                    }

                }
                else
                {
                    var errorMessage = FormatErrorMessage(validationContext.DisplayName);
                    return new ValidationResult(errorMessage);
                }
            }
            else
            {
                var errorMessage = FormatErrorMessage(validationContext.DisplayName);
                return new ValidationResult(errorMessage);
            }

            return ValidationResult.Success;

        }
    }
}
