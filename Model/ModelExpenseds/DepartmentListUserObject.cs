using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Expensed
{
    public class DepartmentListUserObject
    {
        public int Ma { get; set; }
        public string HoTen { get; set; }
        public string TenDangNhap { get; set; }
        public bool Isdaidien { get; set; }
        public string TrangThai { get; set; }
        public int Tongso { get; set; }
        public string HomThu { get; set; }
        public string DienThoai { get; set; }
        public string ChucVu { get; set; }
        public string Email { get; set; }
        public string SoDienThoai { get; set; }

        public bool? KichHoat { get; set; }
    }
}
