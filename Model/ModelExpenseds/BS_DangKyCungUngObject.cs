using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Expensed
{
    public class BS_DangKyCungUngObject
    {
        public long Id { get; set; }
        public long BusinessId { get; set; }
        public byte DangKyCungUng { get; set; }
    }
    public partial class BS_GioiThieuCungUngObject
    {
        public long Id { get; set; }
        public long? BusinessId { get; set; }
        public byte? GioiThieuCungUng { get; set; }
    }
    public partial class BS_HinhThucTuyenDungObject
    {
        public long Id { get; set; }
        public long? BusinessId { get; set; }
        public byte? HinhThucTuyenDung { get; set; }
    }
    public partial class BS_KenhTiepNhanTTObject
    {
        public long Id { get; set; }
        public long? BusinessId { get; set; }
        public byte? KenhTiepNhanTt { get; set; }
    }
}
