using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Expensed
{
    public class DM_ChucVuObject
    {
        public short Id { get; set; }
        public string Code { get; set; }
        public string TenDuLieu { get; set; }
        public bool Loai { get; set; }
        public string MoTa { get; set; }
        public short? Stt { get; set; }
        public bool TrangThai { get; set; }
        public bool Xoa { get; set; }
    }
    public class DM_NhomNguoiDungObject
    {
        public short Id { get; set; }
        public string Code { get; set; }
        public string TenDuLieu { get; set; }
        public bool Loai { get; set; }
        public string MoTa { get; set; }
        public short? Stt { get; set; }
        public bool TrangThai { get; set; }
        public bool Xoa { get; set; }
        public int? DonViId { get; set; }
    }
}
