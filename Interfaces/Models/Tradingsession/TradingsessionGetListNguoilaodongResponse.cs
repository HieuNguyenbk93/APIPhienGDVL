using Common.Constants;
using Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Text;
namespace Interfaces.Models.Tradingsession
{
    public class TradingsessionGetListNguoilaodongResponse : BaseResponse<ResponseStatus>
    {
        public List<TradingsessionNguoilaodong> ListTradingsessionNguoilaodong { get; set; }
        public int TotalRecords2 { get; set; }
    }
    public class TradingsessionNguoilaodong
    {
        public int Id { get; set; }
        public string tennguoilaodong { get; set; }
        public string sodienthoai { get; set; }
        public string nhucautuyendung { get; set; }
        public string chitieutuyendung { get; set; }
        public string lichsugioithieu { get; set; }
        public int TotalRecords2 { get; set; }
        public int PageIndex2 { get; set; }
        public int PageSize2 { get; set; }
    }
}
