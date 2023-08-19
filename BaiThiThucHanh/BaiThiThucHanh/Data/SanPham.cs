﻿using System;
using System.Collections.Generic;

namespace BaiThiThucHanh.Data
{
    public partial class SanPham
    {
        public SanPham()
        {
            ChiTietHoaDons = new HashSet<ChiTietHoaDon>();
        }

        public int MaSp { get; set; }
        public string TenSp { get; set; } = null!;
        public string? DonViTinh { get; set; }
        public double? DonGia { get; set; }
        public string? Hinh { get; set; }

        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }
    }
}
