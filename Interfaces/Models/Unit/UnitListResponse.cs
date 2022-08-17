using Interfaces.Base;
using Common.Constants;
using Model.Expensed;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Model.Unit
{
    public class UnitListResponse : BaseResponse<ResponseStatus>
    {
        public List<UnitListResponseObject> listData { get; set; }
        public int total { get; set; }
    }
}
