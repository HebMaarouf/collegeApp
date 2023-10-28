using System.ComponentModel.DataAnnotations;

namespace collegeApp.Models.Validators
{
    public class DateCheckAttribute:ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var date = (DateTime?)value;
            if(date < DateTime.Now)
            {
                return new ValidationResult(" **Admission date should be greater than or equal to todays date");
            }
            return ValidationResult.Success;
        }
    }
}
