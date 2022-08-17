using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Expensed
{
    public class QLUngVienObject
    {
        public int Id { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string Cmnd { get; set; }
        public bool GioiTinh { get; set; }
        public int DanToc { get; set; }
        public string DiaChi { get; set; }
        public int HuyenId { get; set; }
        public int XaId { get; set; }
        public int TinhId { get; set; }
        public string Sdt { get; set; }
        public string Email { get; set; }
        public string LienHeKhac { get; set; }
        public bool IsDeleted { get; set; }
        public int NguoiTao { get; set; }
        public DateTime NgayTao { get; set; }
        public int NguoiCapNhat { get; set; }
        public DateTime NgayCapNhat { get; set; }
        public byte TrinhDoHocVan { get; set; }
        public byte TrinhDoCmkt { get; set; }
        public string ChuyenNganh { get; set; }
        public string TruongTotNghiep { get; set; }
        public string KyNangNghe { get; set; }
        public string BacKyNangNghe { get; set; }
        public string TrinhDoTinHoc { get; set; }
        public byte? KhaNangTinHoc { get; set; }
        public string KyNangCntt { get; set; }
        public byte? KhaNangThucHanhCntt { get; set; }
        public string KyNangMangXaHoi { get; set; }
        public byte? KhaNangThucHanhXh { get; set; }
        public byte TheThao { get; set; }
        public byte VanNghe { get; set; }
        public byte XaHoi { get; set; }
        public bool CapNhatCv { get; set; }
        public bool SanSangLamViec { get; set; }
    }
}
