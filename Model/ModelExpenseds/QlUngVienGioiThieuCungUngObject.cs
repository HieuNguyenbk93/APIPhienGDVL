using System;
using System.Collections.Generic;

namespace Model.Expensed
{
    public partial class QlUngVienGioiThieuCungUngObject
    {
        public long Id { get; set; }
        public long UngVienId { get; set; }
        public byte GioiThieuCungUng { get; set; }
    }
}
