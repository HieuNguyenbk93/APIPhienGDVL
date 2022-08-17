using Common.Constants;
using Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Models.Business
{
    public class BusinessGetListSuggetResponse : BaseResponse<ResponseStatus>
    {
        public List<BusinessGetListSugget> ListBusiness { get; set; }
        public int TotalRecords { get; set; }
    }
    public class BusinessGetListSugget
    {
        public int Id { get; set; }
        public int STT { get; set; }
        public int Scope { get; set; }
        public int? MaNghe { get; set; }
        public string TenNghe { get; set; }
        public string MucLuong { get; set; }
        public string Ma { get; set; }
        public int? MucLuongOrder { get; set; }
        public string TrinhDoCMKT { get; set; }
        public int? TrinhDoCMKTOrder { get; set; }
        public string ChucDanh { get; set; }
        public int? ChucDanhOrder { get; set; }
        public int? TinhId { get; set; }
        public int? HuyenId { get; set; }
        public string DiaChi { get; set; }
        public string TrinhDoTinHoc { get; set; }
        public int? TrinhDoTinHocOrder { get; set; }
        public string SoTruongHDXH { get; set; }
        public int? SoTruongHDXHOrder { get; set; }
        public string KyNangMXH { get; set; }
        public int? KyNangMXHOrder { get; set; }
        public string TinhChatCV { get; set; }
        public int? TinhChatCVOrder { get; set; }
        public string KinhNghiem { get; set; }
        public int? KinhNghiemOrder { get; set; }
        public string LyDo { get; set; }
        public string HoTen { get; set; }
        public string TenCongViec { get; set; }
        public string Sdt { get; set; }
        public string Ten { get; set; }
        public string TrinhDoHocVan { get; set; }
        public string NoiLamViec { get; set; }
        public int TotalRecords { get; set; }
    }
    //public class BusinessGetListSugget
    //{
    //    public int Id { get; set; }
    //    public int RN { get; set; }
    //    public int Scope { get; set; }
    //    public string MaNghe { get; set; }
    //    public int? MucLuong { get; set; }
    //    public string MucLuongText { get; set; }
    //    public int? TrinhDoCMKT { get; set; }
    //    public string TrinhDoCMKTText { get; set; }
    //    public int? ChucDanh { get; set; }
    //    public string ChucDanhText { get; set; }
    //    public int? TinhId { get; set; }
    //    public int? HuyenId { get; set; }
    //    public string DiaChi { get; set; }
    //    public int? TrinhDoTinHoc { get; set; }
    //    public string TrinhDoTinHocText { get; set; }
    //    public int? XaHoi { get; set; }
    //    public string XaHoiText { get; set; }
    //    public int? MangXaHoi { get; set; }
    //    public string MangXaHoiText { get; set; }
    //    public int? TinhChatCongViec { get; set; }
    //    public string TinhChatCongViecText { get; set; }
    //    public int? YeuCauCongViec { get; set; }
    //    public string YeuCauCongViecText { get; set; }
    //    public int TotalRecords { get; set; }
    //}
}
