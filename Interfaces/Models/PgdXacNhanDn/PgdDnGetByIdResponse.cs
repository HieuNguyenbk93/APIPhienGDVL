using Common.Constants;
using Interfaces.Base;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Models.PgdXacNhanDn
{
    public class PgdDnGetByIdResponse : BaseResponse<ResponseStatus>
    {
        public List<PgdXacNhanDN> PgdDnDangKy { get; set; }
        public List<PgdXacNhanDN> PgdDnDuocMoi { get; set; }
    }
}
