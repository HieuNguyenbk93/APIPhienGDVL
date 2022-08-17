using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Expensed
{
    public class FileAttacthObject
    {
        public int Ma { get; set; }
        public string DuongDan { get; set; }
        public string TenFile { get; set; }
        public byte? Loai { get; set; }
        public int? KichThuoc { get; set; }
        public int? KienNghiId { get; set; }
        public int? MaLichSu { get; set; }
        public int? NguoiUpload { get; set; }
        public short? Version { get; set; }
        public bool? SelectedVersion { get; set; }
        public int? XuLyId { get; set; }
    }

}
