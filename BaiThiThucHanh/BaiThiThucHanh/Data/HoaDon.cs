using System;
using System.Collections.Generic;

namespace BaiThiThucHanh.Data
{
    public partial class HoaDon
    {
        public HoaDon()
        {
            ChiTietHoaDons = new HashSet<ChiTietHoaDon>();
        }

        public int MaHd { get; set; }
        public string MaKh { get; set; } = null!;
        public DateTime NgayLapHd { get; set; }
        public DateTime NgayNhanHang { get; set; }
        public int? MaNv { get; set; }

        public virtual KhachHang MaKhNavigation { get; set; } = null!;
        public virtual NhanVien? MaNvNavigation { get; set; }
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }
    }
}
