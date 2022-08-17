using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Expensed
{
    public class GroupUserObjectModel
    {
        public int Ma { get; set; }
        public string TenNhom { get; set; }
        public string MaNhom { get; set; }
        public string NguoiTao { get; set; }
        public int MaDonVi { get; set; }
        public DateTime? NgayTao { get; set; }
        public bool? TrangThai { get; set; }
        public bool Xoa { get; set; }
        public int SoNguoiDung { get; set; }
    }
}
