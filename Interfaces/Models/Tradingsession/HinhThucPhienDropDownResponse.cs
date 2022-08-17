using Interfaces.Base;
using Common.Constants;
using Model.Expensed;
using System.Collections.Generic;

namespace Interfaces.Models.Tradingsession
{
    public class HinhThucPhienDropDownResponse : BaseResponse<ResponseStatus>
    {
        public List<DropDownObject> ListHinhThucPhien { get; set; }
    }
}
