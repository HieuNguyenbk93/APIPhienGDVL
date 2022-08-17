using System;
using System.Collections.Generic;

namespace Model.Expensed
{
    public partial class QlUngVienHinhThucTuyenDungObject
    {
        public long Id { get; set; }
        public long UngVienId { get; set; }
        public byte HinhThucTuyenDung { get; set; }
    }
}
