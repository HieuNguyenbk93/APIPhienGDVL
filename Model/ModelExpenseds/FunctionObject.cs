using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Expensed
{
    public class FunctionObject
    {
        public short Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public short CategoryId { get; set; }

        public bool Selected { get; set; }

        public ICollection<PermissionObject> HtPermission { get; set; }
    }
}
