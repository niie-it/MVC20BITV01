using System.ComponentModel.DataAnnotations;

namespace Lab04_Validation.Models
{
    public class EmployeeInfo
    {
        [Display(Name ="Họ tên")]
        [MinLength(5, ErrorMessage ="Tối thiểu 5 kí tự")]
        public string FullName { get; set; }

        [Display(Name ="Tuổi")]
        [Range(18, 65, ErrorMessage ="Tuổi từ 18 --> 65")]
        public int Age { get; set; }
    }
}
