using System;
using System.Collections.Generic;

namespace Model
{
    public partial class PgdXacNhanNld
    {
        public int Id { get; set; }
        public int? PhienGiaoDichId { get; set; }
        public int? NguoiLaoDongId { get; set; }
        public int? UngVienId { get; set; }
        public bool? Type { get; set; }
        public int? TrangThai { get; set; }
        public bool? ThamGiaPhien { get; set; }
        public bool? HinhThuc { get; set; }
        public int? DiemSanId { get; set; }
        public int? NguoiTao { get; set; }
        public DateTime? NgayTao { get; set; }
    }
}
