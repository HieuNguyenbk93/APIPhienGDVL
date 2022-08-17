using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Expensed
{
    public class LichSuXuLyObject
    {
        public int Id { get; set; }
        public int DoiTuongId { get; set; }
        public int? Loai { get; set; }
        public string NoiDung { get; set; }
        public string NguoiTao { get; set; }
        public int? TrangThai { get; set; }
        public DateTime? NgayTao { get; set; }
    }
}
