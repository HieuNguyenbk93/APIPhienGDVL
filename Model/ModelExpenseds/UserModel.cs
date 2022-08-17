using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Expensed
{
    public class UserModel
    {
        public int Ma { get; set; }
        public string HoTen { get; set; }
        public bool? KichHoat { get; set; }
        public bool Xoa { get; set; }
        public string TenDangNhap { get; set; }
        public string TenPhongBan { get; set; }
        public string TenChucVu { get; set; }
        public string AnhDaiDien { get; set; }

    }
    public class HtNguoiDungObject
    {
        public int Ma { get; set; }
        public string TenDangNhap { get; set; }
        public string HoTen { get; set; }
        public int? DonViId { get; set; }
        public int? PhongBanId { get; set; }
        public string DienThoai { get; set; }
        public bool? KichHoat { get; set; }
        public bool Xoa { get; set; }
        public bool? GioiTinh { get; set; }
        public string HomThu { get; set; }
        public string DiaChi { get; set; }
        public int? MaChucVu { get; set; }
        public string AnhDaiDien { get; set; }
        public string LoginId { get; set; }
        public bool? IsSuperAdmin { get; set; }
        public bool? IsHaveToken { get; set; }
        public byte? Role { get; set; }
    }
}
