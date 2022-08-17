using Common.Constants;
using Interfaces.Base;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Models.PgdXacNhanDn
{
    public class Pgd_XacNhanDnGetListResponse : BaseResponse<ResponseStatus>
    {
        public List<PgdXacNhanDN> ListPgdDn { get; set; }
    }
}
