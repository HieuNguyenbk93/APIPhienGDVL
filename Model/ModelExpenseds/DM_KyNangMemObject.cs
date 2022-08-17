using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Expensed
{
    public class DM_KyNangMemObject
    {
        public int Id { get; set; }
        public int? Stt { get; set; }
        public string Ma { get; set; }
        public string Ten { get; set; }
        public string MoTa { get; set; }
        public bool TrangThai { get; set; }
        public bool Xoa { get; set; }
    }
   
}
