using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Expensed
{
    public class DepartmentTreeObject
    {
        public int Ma { get; set; }
        public string Ten { get; set; }
        public int? MaCapCha { get; set; }
        public int? LEVEL { get; set; }
        public bool? TrangThai { get; set; }
    }
    public class InfoUnitObject
    {
        public int Ma { get; set; }
        public string Ten { get; set; }
        public string MoTa { get; set; }
        public string SoDienThoai { get; set; }
        public string AnhDaiDien { get; set; }
        public string HoTen { get; set; }
        public string ChucVu { get; set; }
        public string Email { get; set; }
        public int Level { get; set; }
        public bool TrangThai { get; set; }
    }
}
