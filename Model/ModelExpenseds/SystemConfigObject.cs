using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Expensed
{
    public class SystemConfigObject
    {
        public short Id { get; set; }
        public string Code { get; set; }
        public string TenCauHinh { get; set; }
        public string GiaTri { get; set; }
        public string MoTa { get; set; }
        public short? MaDonVi { get; set; }
        public bool? TrangThai { get; set; }

    }
    public class NhomNguoiDungNguoiDungObject
    {
        public short Id { get; set; }
        public int? NhomNguoiDungId { get; set; }
        public int? NguoiDungId { get; set; }
    }
    public class NhomNguoiDungNguoiDungObj
    {
        public short Id { get; set; }
        public int? NhomNguoiDungId { get; set; }
        public int? NguoiDungId { get; set; }
        public string HoTen { get; set; }
        public string TenDangNhap { get; set; }
        public bool? KichHoat { get; set; }
    }
}
