using System;
using System.Collections.Generic;
using System.Text;

namespace Model.ModelExpenseds
{
    public class TemplateGridObject
    {
        public int Id { get; set; }
        public string Ten { get; set; }
        public string Name { get; set; }
        public string DuongDan { get; set; }
        public string Description { get; set; }
        public bool? Active { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int TotalCount { get; set; }
    }
}
