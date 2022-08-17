using System;
using System.Collections.Generic;

namespace Model.Expensed
{
    public class UserObject
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
        public string MatKhau { get; set; }
        public string LoginId { get; set; }
        public bool? IsSuperAdmin { get; set; }
        public bool? IsHaveToken { get; set; }
        public bool? IsMangement { get; set; }
        public bool? CheckFileChange { get; set; }
        public short? Role { get; set; }
        public string UserId { get; set; }
        public string IpAddress { get; set; }
        public string DonVi { get; set; }
        public string PosistionName { get; set; }
        public int phongBan { get; set; }
        public List<int> listPhongBan { get; set; }
        public Object KhoaDangNhap { get; set; }

        public static implicit operator List<object>(UserObject v)
        {
            throw new NotImplementedException();
        }
    }
}
