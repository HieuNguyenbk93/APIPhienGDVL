using Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Models.PgdXacNhanDn
{
    public class PgdDnGetByIdRequest : BaseRequest
    {
        public int Id { get; set; }
    }
}
