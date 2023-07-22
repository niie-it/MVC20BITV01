using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Lab04_Validation.Models
{
    public class Employee
    {
        public Guid? ID { get; set; }

        [Display(Name = "Mã nhân viên")]
        [Remote(action:"CheckExistedEmployeeNo", controller: "Employee")]
        public string EmployeeNo { get; set; }

        [Display(Name = "Họ tên")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Từ 3 - 100 kí tự")]
        public string FullName { get; set; }

        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Display(Name = "Website")]
        [Url]
        public string Website { get; set; }

        [Display(Name = "Ngày sinh")]
        [DataType(DataType.Date)]
        [CheckAgeOfBirthDate]
        public DateTime BirthDate { get; set; }


        [Display(Name = "Giới tính")]
        public bool Gender { get; set; }


        [Display(Name = "Lương")]
        [Range(0, 10000000)]
        public double Salary { get; set; }

        [Display(Name = "Bán thời gian")]
        public bool IsPartTime { get; set; }

        [Display(Name = "Địa chỉ")]
        [RegularExpression("[a-zA-Z]+[a-zA-Z 0-9]*")]
        public string Address { get; set; }


        [Display(Name = "Điện thoại")]
        [RegularExpression("0[3789][0-9]{8}")]
        public string Phone { get; set; }

        [Display(Name = "Số tài khoản")]
        [DataType(DataType.CreditCard)]
        public string CreditCard { get; set; }

        [Display(Name = "Thông tin thêm")]
        [DataType(DataType.MultilineText)]
        [MaxLength(255, ErrorMessage ="Tối đa 255 kí tự")]
        public string Description { get; set; }
    }
}
