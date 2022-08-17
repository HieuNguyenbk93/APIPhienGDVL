using System;
using System.Collections.Generic;
using System.Text;

namespace Model.ModelExpenseds
{
    public class DM_HanhChinhTree
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int Cap { get; set; }
        public int TinhId { get; set; }
        public int QuanHuyenId { get; set; }
        public bool TrangThai { get; set; }
    }
}
