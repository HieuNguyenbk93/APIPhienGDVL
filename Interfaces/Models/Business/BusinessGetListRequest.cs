using Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Models.Business
{
    public class UngVienCreateRequest : BaseRequest
    {
        //public int? Stt { get; set; }
        public string Ma { get; set; }
        public int? MaNghe { get; set; }
        public string CMND { get; set; }
        public string Ten { get; set; }
        public string Sdt { get; set; }
        public string DiaChi { get; set; }
        public string TenCongViec { get; set; }
        public string SoLuongTuyen { get; set; }
        public int? TrangThai { get; set; }
        public int? NguoiCungUng { get; set; }
        public bool? Online { get; set; }
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
    }
    public class BusinessGetListXacNhanTrungLapRequest : BaseRequest
    {
        public int Id { get; set; }
        public string Ma { get; set; }
        public int? MaNghe { get; set; }
        public string Ten { get; set; }
        public string Sdt { get; set; }
        public string DiaChi { get; set; }
        public string TenCongViec { get; set; }
        public string SoLuongTuyen { get; set; }
        public int? TrangThai { get; set; }
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
    }

    public class UngVienSuggetListRequest : BaseRequest
    {
        public int Id { get; set; }
        public List<cols> Scope { get; set; }
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
    }
    public class cols
    {
        public string field { get; set; }
        public string header { get; set; }
    }
    public class UngVienSuggetListByRequest : BaseRequest
    {
        public int Id { get; set; }
 
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
    }
}
