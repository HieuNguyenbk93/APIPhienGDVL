using Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Models.Tradingsession
{
    public class TradingsessionGetListRequest : BaseRequest
    {
        public int id { get; set; }
        public string tieuDe { get; set; }
        public int? hinhThucId { get; set; }
        public string moTa { get; set; }
        public string gio_bd_str { get; set; }
        public string gio_kt_str { get; set; }
        public string gio_handk_str { get; set; }
        public string hangdangky { get; set; }
        public string thoigian_bd { get; set; }
        public string thoigian_kt { get; set; }
        public string hangdangky_bd { get; set; }
        public string handangky_kt { get; set; } 
        public bool trangThaiCongBo { get; set; }
        public int? trangThaiCongBoId { get; set; }        
        public bool isDeleted { get; set; }
        public bool nguoiTao { get; set; }
        public string ngayTao { get; set; }
        public int? nguoiCapNhat { get; set; }
        public string ngayCapNhat { get; set; }
        public int pageIndex { get; set; }
        public int pageSize { get; set; }
    }
}
