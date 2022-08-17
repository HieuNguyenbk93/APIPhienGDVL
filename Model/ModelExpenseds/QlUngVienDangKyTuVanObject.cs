using System;
using System.Collections.Generic;
namespace Model.Expensed
{
    public partial class QlUngVienDangKyTuVanObject
    {
        public long Id { get; set; }
        public long UngVienId { get; set; }
        public byte DangKyTuVan { get; set; }
    }
}
