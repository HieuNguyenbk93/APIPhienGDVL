using Common.Constants;
using Interfaces.Base;
using Model.Expensed;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Model.Unit
{
    public class UnitDropDownReponse : BaseResponse<ResponseStatus>
    {
        public List<UnitDropdownObject> listData { get; set; }
    }
}
