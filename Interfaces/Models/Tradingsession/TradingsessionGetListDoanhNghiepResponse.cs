using Common.Constants;
using Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Text;
namespace Interfaces.Models.Tradingsession
{
    public class TradingsessionGetListDoanhNghiepResponse : BaseResponse<ResponseStatus>
    {
        public List<TradingsessionDoanhNghiep> ListTradingsessionDoanhNghiep { get; set; }
        public int TotalRecords1 { get; set; }
    }
    public class TradingsessionDoanhNghiep
    {
        public int Id { get; set; }
        public string tendoanhnghiep { get; set; }
        public string sodienthoai { get; set; }
        public string nhucautuyendung { get; set; }
        public string chitieutuyendung { get; set; }
        public string lichsugioithieu { get; set; }
        public int TotalRecords1 { get; set; }
        public int PageIndex1 { get; set; }
        public int PageSize1 { get; set; }
    }
}
