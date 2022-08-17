using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Expensed
{
    public class UnitListRequestObject
    {
        public short? Ma { get; set; }
        public string TenVietTatGoc { get; set; }
        public string TenVietTat { get; set; }
        public string DienGiai { get; set; }
        public string TenXa { get; set; }
        public string TenTinh { get; set; }
        public string TenHuyen { get; set; }
        public bool? TrangThai { get; set; }
        public int PageSize { get; set; }
        public int PageIndex { get; set; }
    }
}
