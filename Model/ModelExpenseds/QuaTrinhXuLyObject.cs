using System;
using System.Collections.Generic;
using System.Text;

namespace Model.ModelExpenseds
{
    public class QuaTrinhXuLyObject
    {
        public int Ma { get; set; }
        public DateTime NgayThucHien { get; set; }
        public string NoiDungLichSu { get; set; }
        public string NoiDungThongBao { get; set; }
        public int NguoiThucHien { get; set; }
        public string HoTen { get; set; }
        public string TenDangNhap { get; set; }
        public byte LoaiHanhDong { get; set; }
    }

    public class QuaTrinhXuLyQuyTienTeObject
    {
        public int Id { get; set; }
        public DateTime NgayTao { get; set; }
        public string HoTen { get; set; }
        public string NoiDungLichSu { get; set; }
        public string NoiDungThongBao { get; set; }
        public int NguoiThucHien { get; set; }
        public byte Loai { get; set; }
    }
}
