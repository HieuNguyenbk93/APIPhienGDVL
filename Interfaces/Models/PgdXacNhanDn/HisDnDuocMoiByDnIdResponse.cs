using Common.Constants;
using Interfaces.Base;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Models.PgdXacNhanDn
{
    public class HisDnDuocMoiByDnIdResponse : BaseResponse<ResponseStatus>
    {
        public List<HisDnDuocMoi> ListHisDnDuocMoi { get; set; }
    }
}
