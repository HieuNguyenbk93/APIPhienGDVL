using Common.Constants;
using Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Models.Business
{
    public class BusinessGetListResponse : BaseResponse<ResponseStatus>
    {
        public List<ListBusiness> ListBusiness { get; set; }
        public int TotalRecords { get; set; }
    }
    public class ListBusiness
    {
        public int Id { get; set; }
        public string Ma { get; set; }
        public string MaNghe { get; set; }
        public string TenNghe { get; set; }
        public string CMND { get; set; }
        public string Ten { get; set; }
        public string Sdt { get; set; }
        public string DiaChi { get; set; }
        public string TenCongViec { get; set; }
        public int SoLuongTuyen { get; set; }
        public int? TrangThai { get; set; }       
        public int TotalRecords { get; set; }
        public int? ChucVu { get; set; }
        public int? GioiTinh { get; set; }
        public int? TongIdTuoi { get; set; }
        public int? TrinhDoHocVan { get; set; }
        public int? TrinhDoCMKT { get; set; }
        public int? YeuCauKinhNghiem { get; set; }
        public int? ChucDanh { get; set; }
        public int? MucLuong { get; set; }
        public int? CheckTrung { get; set; }
        public string AnhDaiDien { get; set; }
        public bool? Online { get; set; }
        public int? NguoiTiepNhan { get; set; }
        public int? NguoiCungUng { get; set; }
        public string TenNguoiCungUng { get; set; }
    }
}
