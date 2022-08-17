using Common.Constants;
using Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Models.Tradingsession
{
    public class TradingsessionGetListDetailResponse : BaseResponse<ResponseStatus>
    {
        public List<DetailTradingSession> ListDetailTradingSession { get; set; }
        public int TotalRecords { get; set; }
        public List<TradingsessionDoanhNghiep> ListTradingsessionDoanhNghiep { get; set; }
    }
    public class DetailTradingSession
    {
        public int id { get; set; }
        public string sodoanhnghiep { get; set; }
        public string songuoilaodong { get; set; }
        public string sochitieu { get; set; }
        public string sovitrivieclam { get; set; }
    }
}
