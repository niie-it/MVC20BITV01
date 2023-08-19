namespace BaiThiThucHanh.Models
{
    public class HoaDonVM
    {
        //MaSP, TenSP, DonViTinh, DonGia, SoLuong, ThanhTien
        public int MaSp { get; set; }
        public string TenSp { get; set; }
        public string DonViTinh { get; set; }
        public double DonGia { get; set; }
        public int SoLuong { get; set; }
        public double ThanhTien => SoLuong * DonGia;
        //public double ThanhTien
        //{
        //    get { return SoLuong * DonGia; }
        //}
    }
}
