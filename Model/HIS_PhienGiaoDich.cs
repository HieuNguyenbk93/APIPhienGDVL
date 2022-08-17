using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class HIS_PhienGiaoDich
    {
        public int Id { get; set; }
        public int ObjectId { get; set; }
        public int? Type { get; set; }
        public string Contents { get; set; }
        public byte Status { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
