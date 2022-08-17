using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Expensed
{
    public class RequestObject
    {
        public int Id { get; set; }
        public string MaKienNghi { get; set; }
        public int? ThoiGianId { get; set; }
        public int? NguonId { get; set; }
        public int? LinhVucId { get; set; }
        public int? TinhId { get; set; }
        public int? QuanHuyenId { get; set; }
        public int? PhuongXaId { get; set; }
        public int? PhanLoaiId { get; set; }
        public int? KienNghiTrungId { get; set; }
        public DateTime? ThoiHanGiaiQuyet { get; set; }
        public byte? TrangThai { get; set; }
        public string TenCaNhanDonVi { get; set; }
        public string NoiDungKienNghi { get; set; }
        public byte? Step { get; set; }
        public bool? IsPublic { get; set; }
        public DateTime? PublicDate { get; set; }
        public int? NguoiTao { get; set; }
        public DateTime? NgayTao { get; set; }
        public bool? KncoChe { get; set; }
        public bool? KnnguonLuc { get; set; }
        public short? ThoiHanNgay { get; set; }
        public bool? IsRepeat { get; set; }
        public bool? KnthamQuyen { get; set; }
        public int? RepeatKnid { get; set; }
        public int? RepeatedKnid { get; set; }
        public string NoiCoKienNghi { get; set; }
        public string TienDoGiaiQuyet { get; set; }
    }
}
