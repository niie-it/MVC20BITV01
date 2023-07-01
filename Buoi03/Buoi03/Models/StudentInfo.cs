using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Buoi03.Models
{
    public class StudentInfo
    {
        [DisplayName("Mã số SV")]
        public int StudentId { get; set; }

        [DisplayName("Họ tên SV")]
        public string StudentName { get; set; }

        [DisplayName("Điểm")]
        [Range(0, 10, ErrorMessage ="Không hợp, điểm từ 0 --> 10")]
        public double Mark { get; set; }

        public string? Grade
        {
            get
            {
                if (Mark >= 8.5) return "A";
                if (Mark >= 7) return "B";
                if (Mark >= 5.5) return "C";
                if (Mark >= 4) return "D";
                return "F";
            }
        }
    }
}
