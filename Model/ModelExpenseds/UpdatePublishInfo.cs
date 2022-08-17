using System;
using System.Collections.Generic;
using System.Text;

namespace Model.ModelExpenseds
{
    public class UpdatePublishInfo
    {
        public int KnId { get; set; }
        public bool IsPublish { get; set; }
        public DateTime? PublishDate { get; set; }
        public string KenhCongBo { get; set; }
    }
}
