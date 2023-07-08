using System.ComponentModel.DataAnnotations;

namespace Lab04_Validation.Models
{
    public class CheckAgeOfBirthDateAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            try
            {
                var birthDate = value as DateTime?;
                if (birthDate != null)
                {
                    if(DateTime.Now.Year - birthDate.Value.Year < 18)
                    {
                        return new ValidationResult("Chưa đủ tuổi làm việc");
                    }
                }
                return ValidationResult.Success;
            }
            catch (Exception ex)
            {
                return new ValidationResult("Ngày sinh không hợp lệ");
            }
        }
        //public override bool IsValid(object? value)
        //{
        //    return base.IsValid(value);
        //}
    }
}