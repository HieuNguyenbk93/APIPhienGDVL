using Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Models.Business
{
    public class BusinessHistoryByIdGetListRequest : BaseRequest
    {
        //public int? Stt { get; set; }
        public int  id { get; set; }
        public DateTime? fromdate { get; set; }
        public DateTime? todate { get; set; }
        public int pageindex { get; set; }
        public int pagesize { get; set; }
    }
}
