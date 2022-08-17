using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Expensed
{
    public class DropDownObject
    {
        public int Value { get; set; }
        public string Text { get; set; }
        public string Code { get; set; }
    }
    public class DropDownGroup
    {
        public int? Value { get; set; }
        public string Label { get; set; }
        public string Level { get; set; }
        public List<DropDownGroup> Items { get; set; }
    }
    public class DropDownSelectObject
    {
        public long? Id { get; set; } = 0;
        public int Value { get; set; }
        public string Text { get; set; }
        public string Code { get; set; }
        public byte? GiaTri { get; set; }
    }
}
