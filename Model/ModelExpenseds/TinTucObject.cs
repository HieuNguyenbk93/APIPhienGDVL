using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Expensed
{
    public class TinTucObject
    {
        public int Id { get; set; }
        public string Ten { get; set; }
        public string TomTat { get; set; }
        public string NoiDung { get; set; }
        public string AnhDaiDien { get; set; }
        public int? ChuyenMucId { get; set; }
        public int? KieuBai { get; set; }
        public int? TrangThai { get; set; }
        public int? LuotXem { get; set; }
        public string DuongDan { get; set; }
        public int? NguoiTao { get; set; }
        public DateTime? NgayTao { get; set; }
        public int? NguoiCapNhat { get; set; }
        public DateTime? NgayCapNhat { get; set; }
        public int? NguoiCongBo { get; set; }
        public DateTime? NgayCongBo { get; set; }
        public int? NguoiThuHoi { get; set; }
        public DateTime? NgayThuHoi { get; set; }
    }
}
