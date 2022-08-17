using Common.Constants;
using Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Models.Tradingsession
{
    public class TradingsessionGetListResponse : BaseResponse<ResponseStatus>
    {
        public List<TradingsessonGetList> ListTradingsesson { get; set; }
        public int TotalRecords { get; set; }
    }
    public class TradingsessonGetList
    {
        public int Id { get; set; }
        public int? HinhThucId { get; set; }
        public string HinhThuc { get; set; }
        public string TieuDe { get; set; }
        public string MoTa { get; set; }
        public string HanDangKy_Ngay { get; set; }
        public string HanDangKy_GioPhut { get; set; }
        public string ThoiGianBD_Ngay { get; set; }
        public string ThoiGianBD_GioPhut { get; set; }
        public string ThoiGianKT_Ngay { get; set; }
        public string ThoiGianKT_GioPhut { get; set; }
        public string TrangThaiCongBo { get; set; }
        public int? TrangThaiCongBoId { get; set; }
        public int TotalRecords { get; set; }
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
    }
}
