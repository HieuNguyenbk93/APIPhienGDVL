using System;
using System.Collections.Generic;

namespace Model.Expensed
{
    public partial class QlUngVienDangKyCungUngObject
    {
        public long Id { get; set; }
        public long UngVienId { get; set; }
        public byte DangKyCungUng { get; set; }
    }
}
