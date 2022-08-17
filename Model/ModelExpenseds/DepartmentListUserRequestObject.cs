using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Expensed
{
    public class DepartmentListUserRequestObject
    {
        public string Tennguoidung { get; set; }
        public string Tendangnhap { get; set; }
        public int Pagesize { get; set; }
        public int PageIndex { get; set; }
        public int DepartmentId { get; set; }
        public int TrangThai { get; set; }
    }
}
