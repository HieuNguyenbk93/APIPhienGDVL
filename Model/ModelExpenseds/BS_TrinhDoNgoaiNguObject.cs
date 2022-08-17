using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Expensed
{
    public class BS_TrinhDoNgoaiNguObject
    {
        public long Id { get; set; }
        public long BusinessId { get; set; }
        public string Ten { get; set; }
        public string ChungChi { get; set; }
        public byte KhaNang { get; set; }

    }
}
