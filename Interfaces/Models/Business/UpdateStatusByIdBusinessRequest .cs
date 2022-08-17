using Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Models.Business
{
    public class UpdateStatusByIdBusinessRequest : BaseRequest
    {
        public int Id { get; set; }
        public byte TrangThai { get; set; }
        public string NoiDung { get; set; }
        public int? Loai { get; set; }
    }

    
}
