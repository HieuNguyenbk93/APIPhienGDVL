using System;
using System.Collections.Generic;
using System.Text;

namespace Model.ModelExpenseds
{
    public class HanhChinhObject
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public short? TinhId { get; set; }
        public short? QuanHuyenId { get; set; }
        public byte? Cap { get; set; }
        public bool? TrangThai { get; set; }
        public bool? Xoa { get; set; }
        public bool? IsDefault { get; set; }
        public short? NamId { get; set; }
    }
}
