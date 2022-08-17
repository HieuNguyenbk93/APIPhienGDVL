using Common.Constants;
using Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Models.Business
{
    public class BusinessHistoryByIdGetListResponse : BaseResponse<ResponseStatus>
    {
        public List<ListHistoryById> ListData { get; set; }
        public int TotalRecords { get; set; }
    }
    public class ListHistoryById
    {
        public int Id { get; set; }
        public string HoTen { get; set; }
        public int ObjectId { get; set; }
        public int? Type { get; set; }
        public string Contents { get; set; }
        public int Status { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int TotalRecords { get; set; }
        public string AnhDaiDien { get; set; }
        public string TenChucVu { get; set; }

    }
}
