using Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Models.Tradingsession
{
    public class TradingsessionGetListNguoilaodongRequest : BaseRequest
    {
        public int id { get; set; }
        public string pageSize { get; set; }
        public string pageIndex { get; set; }
        public string tennguoilaodong { get; set; }
        public string sodienthoai { get; set; }
        public string nhucautuyendung { get; set; }
        public string chitieutuyendung { get; set; }
        public int ? lichsugioithieu { get; set; }
    }
}
