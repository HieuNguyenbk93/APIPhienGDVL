using System;
using System.Collections.Generic;

namespace Model.Expensed
{
    public partial class QlUngVienTrinhDoCmktkhacObject
    {
        public long Id { get; set; }
        public long UngVienId { get; set; }
        public byte? TrinhDo { get; set; }
        public string ChuyenNganhDaoTao { get; set; }
        public string TruongTotNghiep { get; set; }
    }
}
