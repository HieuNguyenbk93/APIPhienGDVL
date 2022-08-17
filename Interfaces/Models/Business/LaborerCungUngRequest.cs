using Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Models.Business
{
    public class LaborerCungUngRequest : BaseRequest
    {
        public List<CungUngNSDLD> cungUngNDSLDs { get; set; }
        public int? dot { get; set; }
    }
    public class CungUngNSDLD
    {
        public int IdNSDLD { get; set; }
        public int Id { get; set; }
        public int? DotCungUng { get; set; }
        public bool CungUng { get; set; }
        public string LyDo { get; set; }
        public bool? HuuIch { get; set; }
    }
}
