using Interfaces.Base;
using Model.Expensed;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Model.Unit
{
    public class UnitListRequest : BaseRequest
    {
        public short Ma { get; set; }
        public short? Stt { get; set; }
        public string Ten { get; set; }
        public string MoTa { get; set; }
        public string SoDienThoai { get; set; }
        public bool? KichHoat { get; set; }
        public string Code { get; set; }
        public short? KhuVucId { get; set; }
        public short? NguoiPhuTrachId { get; set; }
        public int PageSize { get; set; }
        public int PageIndex { get; set; }
    }
}
