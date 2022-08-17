using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Expensed
{
    public class DepartmentObject
    {
        public int Ma { get; set; }
        public short? MaCapCha { get; set; }
        public string Ten { get; set; }
        public string MoTa { get; set; }
        public string DiaChi { get; set; }
        public string HoTen { get; set; } 
        public string SoDienThoai { get; set; }
        public bool? TrangThai { get; set; }
        public bool Xoa { get; set; }
        public string Code { get; set; }
        public byte? LoaiPhongBan { get; set; }

        public string Email { get; set; }

        public List<int> lstNguoiThamGia { get; set; }
        public int? NguoiDaiDienId { get; set; }
        public string NguoiDaiDienName { get; set; }
        public string NguoiDaiDienChucVu { get; set; }
        public string NguoiDaiDienAnhDaiDien { get; set; }
        public bool IsDiemSan { get; set; }

    }

    public class DropdownDepartmentObject
    {
        public string Text { get; set; }
        public string Value { get; set; }
        public byte? LoaiPhongBan { get; set; }
    }
}
