using Common.Constants;
using Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Models.Business
{
    public class LaborerCungUngResponse : BaseResponse<ResponseStatus>
    {
        public int? Dot { get; set; }
        public int? IdNSDLD { get; set; }
    }
}
