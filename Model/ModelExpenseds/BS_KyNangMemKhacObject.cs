using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Expensed
{
    public class BS_KyNangMemKhacObject
    {
        public long Id { get; set; }
        public long BusinessId { get; set; }
        public int KyNangMemId { get; set; }
        public byte KhaNang { get; set; }

    }
    public class BS_KyNangMemKhacDropDownSelectObject
    {
        public long? Id { get; set; } = 0;
        public int? GiaTri { get; set; }
        public int Value { get; set; }
        public string Text { get; set; }
        public string Code { get; set; }
    }
}
