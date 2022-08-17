using Common.Constants;
using Interfaces.Base;
using Model.Expensed;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Models.Commons
{
    public class DropdownResponse : BaseResponse<ResponseStatus>
    {
        public List<DropDownObject> ListDropDown { get; set; }
    }
}
