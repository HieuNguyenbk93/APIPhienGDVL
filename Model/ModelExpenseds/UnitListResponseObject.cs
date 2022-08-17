using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Expensed
{
    public class UnitListResponseObject
    {
        public short Ma { get; set; }
        public short? Stt { get; set; }
        public string Ten { get; set; }
        public string MoTa { get; set; }
        public string SoDienThoai { get; set; }
        public bool? KichHoat { get; set; }
        public bool Xoa { get; set; }
        public string Code { get; set; }
        public short? KhuVucId { get; set; }
        public short? NguoiPhuTrachId { get; set; }
        public short? MaCapCha { get; set; }
    }
}
