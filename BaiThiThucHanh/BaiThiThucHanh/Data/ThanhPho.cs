using System;
using System.Collections.Generic;

namespace BaiThiThucHanh.Data
{
    public partial class ThanhPho
    {
        public ThanhPho()
        {
            KhachHangs = new HashSet<KhachHang>();
        }

        public int MaThanhPho { get; set; }
        public string? TenThanhPho { get; set; }

        public virtual ICollection<KhachHang> KhachHangs { get; set; }
    }
}
