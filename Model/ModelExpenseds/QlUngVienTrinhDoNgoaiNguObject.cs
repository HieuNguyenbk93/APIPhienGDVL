using System;
using System.Collections.Generic;

namespace Model.Expensed
{
    public partial class QlUngVienTrinhDoNgoaiNguObject
    {
        public long Id { get; set; }
        public long UngVienId { get; set; }
        public string Ten { get; set; }
        public string ChungChi { get; set; }
        public byte? KhaNang { get; set; }
    }
}
