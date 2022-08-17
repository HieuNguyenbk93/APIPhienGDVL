using System;
using System.Collections.Generic;
using System.Text;

namespace Model.ModelExpenseds
{
    public class RegionObject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int? TinhId { get; set; }
        public int? QuanHuyenId { get; set; }
        public byte? Cap { get; set; }
        public bool? TrangThai { get; set; }
        public bool? Xoa { get; set; }
        public bool? IsDefault { get; set; }
        public short? NamId { get; set; }
    }
    public class DM_HanhChinhSuggestObject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ParentId { get; set; }
    }
}
