using System;
using System.Collections.Generic;

namespace BaiThiThucHanh.Data
{
    public partial class KhachHang
    {
        public KhachHang()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        public string MaKh { get; set; } = null!;
        public string TenCty { get; set; } = null!;
        public string? DiaChi { get; set; }
        public string? DienThoai { get; set; }
        public int ThanhPho { get; set; }

        public virtual ThanhPho ThanhPhoNavigation { get; set; } = null!;
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
