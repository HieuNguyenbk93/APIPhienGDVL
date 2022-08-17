using System;
using System.Collections.Generic;

namespace Model
{
    public partial class HtDonVi
    {
        public int Ma { get; set; }
        public string Ten { get; set; }
        public string Email { get; set; }
        public string MoTa { get; set; }
        public string SoDienThoai { get; set; }
        public bool? TrangThai { get; set; }
        public bool Xoa { get; set; }
        public short? MaCapCha { get; set; }
        public string DiaChi { get; set; }
        public int? NguoiDaiDienId { get; set; }
        public bool IsDiemSan { get; set; }
    }
}
