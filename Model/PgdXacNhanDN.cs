using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public partial class PgdXacNhanDN
    {
        public long Id { get; set; }
        public long? PhienGiaoDichId { get; set; }
        public long? BusinessId { get; set; }
        public long? NTDId { get; set; }
        public bool? Type { get; set; }
        public byte? TrangThai { get; set; }
        public bool? ThamGiaPhien { get; set; }
        public bool? HinhThuc { get; set; }
        public int? DiemSanId { get; set; }
        public int? NguoiTao { get; set; }
        public DateTime? NgayTao { get; set; }
    }
}
