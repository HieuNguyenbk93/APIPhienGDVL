using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Expensed
{
    public class PermissionObject
    {
        public PermissionObject()
        {
            CheckedKeys = new List<int>();
        }
        public short Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public short CategoryId { get; set; }
        public short? ParentId { get; set; }

        public bool Selected { get; set; }
        public List<int> CheckedKeys { get; set; }
    }
}
