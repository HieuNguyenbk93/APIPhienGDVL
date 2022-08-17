using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Expensed
{
    public class QLNhaTuyenDungObject
    {
        public int Id { get; set; }
        public string Ten { get; set; }
        public bool ChuTheTuyenDung { get; set; }
        public string Cmnd { get; set; }
        public int LoaiDoanhNghiep { get; set; }
        public string Kcn { get; set; }
        public string DiaChi { get; set; }
        public int HuyenId { get; set; }
        public int XaId { get; set; }
        public int TinhId { get; set; }
        public string Sdt { get; set; }
        public string Email { get; set; }
        public int NganhKinhDoanh { get; set; }
        public string SanPham { get; set; }
        public int QuyMoLd { get; set; }
        public bool? CapNhatCv { get; set; }
        public string DaiDien { get; set; }
        public string SdtLh { get; set; }
        public string EmailLh { get; set; }
        public int? ChucVu { get; set; }
        public bool IsDeleted { get; set; }
        public bool? CopyThongTin { get; set; }
        public int? NguoiTao { get; set; }
        public DateTime? NgayTao { get; set; }
        public int? NguoiCapNhat { get; set; }
        public DateTime? NgayCapNhat { get; set; }
    }
}
