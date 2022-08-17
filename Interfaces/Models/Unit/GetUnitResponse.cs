using System.Collections.Generic;
using Interfaces.Base;
using Common.Constants;
using Model;

namespace Interfaces.Model.Unit
{
    public class GetUnitResponse : BaseResponse<ResponseStatus>
    {
        public HtDonVi data { get; set; }
    }
}