using System;
using System.Collections.Generic;

namespace Model.Expensed
{
    public partial class QlUngVienKyNangMemKhacObject
    {
        public long Id { get; set; }
        public long UngVienId { get; set; }
        public int KyNangMemId { get; set; }
        public byte KhaNang { get; set; }
    }
}
