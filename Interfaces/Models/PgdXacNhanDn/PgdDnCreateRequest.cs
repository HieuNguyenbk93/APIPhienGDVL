using Interfaces.Base;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Models.PgdXacNhanDn
{
    public class PgdDnCreateRequest : BaseRequest
    {
        public List<PgdXacNhanDN> listNhaTuyenDungInvite { get; set; }
    }
}
