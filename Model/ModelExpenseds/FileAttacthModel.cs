using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Expensed
{
    public class FileAttacthModel
    {
        public int Ma { get; set; }
        public string DuongDan { get; set; }
        public string Name { get; set; }
        public byte? Loai { get; set; }
        public int? KienNghiId { get; set; }
        public int? MaLichSu { get; set; }
        public int? NguoiUpload { get; set; }
        public short? Version { get; set; }
        public bool? SelectedVersion { get; set; }
    }
    public class FileAttacthRenew
    {
        public int Ma { get; set; }
        public string DuongDan { get; set; }
        public string Name { get; set; }
        public int? GiaHanId { get; set; }
        public int? NguoiUpload { get; set; }
        public DateTime? NgayTao { get; set; }
    }
    public class FileAttacthProcess
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
        public DateTime? NgayTao { get; set; }
        public int? XuLyId { get; set; }
    }

    public class FileAttacthModelThongTin
    {
        public int Id { get; set; }
        public byte? Loai { get; set; }
        public int? KienNghiId { get; set; }
        public int? NguoiUpload { get; set; }
        public string SoVanBan { get; set; }
        public string NguoiKy { get; set; }
        public string CoQuan { get; set; }
        public string TrichYeu { get; set; }
    }

    public class ThongTinBoSung
    {
        public int? Id { get; set; }
        public int? KienNghiId { get; set; }
        public int? Step { get; set; }
        public string SoVanBan { get; set; }
        public string NguoiKy { get; set; }
        public string CoQuan { get; set; }
        public string TrichYeu { get; set; }
        public string YKienXuLy { get; set; }

        public string DuongDan { get; set; }
        public int? NguoiUpload { get; set; }
        public string TenFile { get; set; }
        public DateTime? NgayTao { get; set; }
    }

}
