using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Expensed
{
    public class GroupUserObject
    {
        public short Ma { get; set; }
        public string TenNhom { get; set; }
        public string MaNhom { get; set; }
        public int? NguoiTao { get; set; }
        public int? MaDonVi { get; set; }
        public string MoTa { get; set; }
        public DateTime? NgayTao { get; set; }
        public bool? TrangThai { get; set; }
        public bool? Xoa { get; set; }

        public bool Selected { get; set; } 
        public List<short> PermissionIds { get; set; }

        public string TenNguoiTao { get; set; }
        public int SoNguoiDung { get; set; }
    }
}
